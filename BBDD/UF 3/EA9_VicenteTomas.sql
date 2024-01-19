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
