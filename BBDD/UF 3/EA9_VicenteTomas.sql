    -- EX 1 --
CREATE OR REPLACE FUNCTION trig_nom_departament_notnull() RETURNS TRIGGER LANGUAGE plpgsql AS $$
BEGIN
    IF NEW.DEPARTMENT_NAME IS NULL THEN
        RAISE EXCEPTION 'El nom del departament no pot ser null';
    END IF;
    RETURN NEW;
END;
$$;

CREATE TRIGGER trig_nom_departament_notnull
BEFORE INSERT ON DEPARTMENTS
FOR EACH ROW
EXECUTE FUNCTION trig_nom_departament_notnull();

INSERT INTO DEPARTMENTS VALUES (3, 'prova3', 200, 1700);
1 Row affected in 51 ms (bé)
INSERT INTO DEPARTMENTS VALUES (3, NULL, 200, 1700);
El nom del departament no pot ser null

-- EX 2 --
CREATE OR REPLACE FUNCTION func_restriccions_emp() RETURNS TRIGGER language plpgsql AS $$
    BEGIN
        IF(NEW.SALARY < 0) THEN
            RAISE 'El salary no pot ser negatiu';
        END IF;
        IF (NEW.SALARY < OLD.SALARY) THEN
            RAISE 'El salary no pot ser inferior al anterior';
        END IF;
        IF (NEW.SALARY <> OLD.SALARY AND OLD.COMMISSION_PCT IS NULL) THEN
            RAISE 'No es pot modificar el salary si la comissió es nula';
        end if;
        RETURN NEW;
END;$$;

CREATE TRIGGER trig_restriccions_emp
    BEFORE INSERT OR UPDATE ON EMPLOYEES
    FOR EACH ROW
    EXECUTE FUNCTION func_restriccions_emp();

INSERT INTO EMPLOYEES VALUES (1, 'juan', 'perez', 'jpez', 5151234566, '1987-07-16', 'AD_PRES', -23, NULL, NULL, 90);
UPDATE EMPLOYEES SET SALARY = 23000.00 WHERE employee_id = 100;
UPDATE EMPLOYEES SET SALARY = 25000.00 WHERE employee_id = 100;

-- EX 3 --
CREATE OR REPLACE FUNCTION trig_comissio() RETURNS TRIGGER LANGUAGE plpgsql AS $$
    BEGIN
        IF NEW.COMMISSION_PCT > NEW.SALARY THEN
            RAISE 'La commisio no pot ser major al salari';
        END IF;
        RETURN NEW;
END;$$;

CREATE TRIGGER trig_comissio
BEFORE INSERT ON EMPLOYEES
FOR EACH ROW
EXECUTE FUNCTION trig_comissio();

INSERT INTO EMPLOYEES VALUES (2, 'sancho', 'perez', 'jpez', 5151234566, '1987-07-16', 'AD_PRES', 0, 0.4, NULL, 90); /*Funciona*/
INSERT INTO EMPLOYEES VALUES (2, 'sancho', 'panza', 'jpez', 5151234566, '1987-07-16', 'AD_PRES', 0, 1, NULL, 90); /*Salta exepcio*/

-- EX 4 --
CREATE OR REPLACE FUNCTION trig_errada_modificacio () RETURNS TRIGGER LANGUAGE plpgsql AS $$
    BEGIN
        IF NEW.FIRST_NAME <> OLD.FIRST_NAME THEN
            RAISE EXCEPTION 'No es pot modificar el nom de l empleat';
        END IF;
        IF NEW.EMPLOYEE_ID <> OLD.EMPLOYEE_ID THEN
            RAISE EXCEPTION 'No es pot modificar el codi de l empleat';
        END IF;
        IF NEW.SALARY > OLD.SALARY*0.10 THEN
            RAISE EXCEPTION 'El salari no pot ser superior al 10%% de l anterior';
        END IF;
        RETURN NULL;
END;$$;

CREATE TRIGGER trig_errada_modificacio
BEFORE UPDATE ON EMPLOYEES
FOR EACH ROW EXECUTE FUNCTION trig_errada_modificacio();

UPDATE employees SET first_name = 'quijote' WHERE employee_id = 100; /*Salta exepcio del nom*/
UPDATE employees SET employee_id = 99 WHERE employee_id = 100; /*Salta exepcio del codi */
UPDATE employees SET salary = 100000 WHERE employee_id = 100; /*Salta exepcio del salari*/

-- EX 5 --
CREATE TABLE RESAUDITAREMP (
    RESULTAT VARCHAR(200)
);

CREATE OR REPLACE FUNCTION trig_auditartaulaemp() RETURNS TRIGGER LANGUAGE plpgsql AS $$
    BEGIN
        INSERT INTO RESAUDITAREMP VALUES (CONCAT(TG_NAME, ' - ',TG_WHEN, ' - ',TG_LEVEL, ' - ', TG_OP, ' - ', NOW()));
        RETURN NULL;
END;$$;

CREATE TRIGGER trig_auditartaulaemp
AFTER INSERT OR UPDATE OR DELETE ON EMPLOYEES
FOR EACH ROW EXECUTE FUNCTION trig_auditartaulaemp();

INSERT INTO EMPLOYEES VALUES (1, 'sancho', 'panza', 'spanz', 5151756566, '1987-06-17', 'AD_PRES', 8300, NULL, NULL, 90);
UPDATE EMPLOYEES SET MANAGER_ID = 205 WHERE employee_id = 1;
DELETE FROM EMPLOYEES WHERE employee_id = 1;
SELECT * FROM RESAUDITAREMP;