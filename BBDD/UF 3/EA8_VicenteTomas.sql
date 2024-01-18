-- EX 1 --
DO $$
    DECLARE
        var_depId EMPLOYEES.DEPARTMENT_ID%TYPE := :vdepid;
        reg_employee RECORD;
        curs_emp CURSOR (param_depid EMPLOYEES.DEPARTMENT_ID%TYPE) FOR
            SELECT EMPLOYEES.EMPLOYEE_ID, EMPLOYEES.LAST_NAME
            FROM EMPLOYEES
            WHERE DEPARTMENT_ID = param_depid;
    BEGIN
        OPEN curs_emp(var_depId);

        LOOP
            FETCH curs_emp INTO reg_employee;
            EXIT WHEN NOT FOUND;
            RAISE NOTICE 'Codi: %, Cognom: %',reg_employee.EMPLOYEE_ID, reg_employee.LAST_NAME;
        END LOOP;
        CLOSE curs_emp;
END;$$

-- EX 2 --
CREATE OR REPLACE FUNCTION func_comp_dep (param_depId EMPLOYEES.DEPARTMENT_ID%TYPE) RETURNS BOOLEAN LANGUAGE plpgsql AS $$
BEGIN
    IF EXISTS (SELECT 1 FROM EMPLOYEES WHERE DEPARTMENT_ID = param_depId) THEN
        RETURN TRUE;
    ELSE
        RAISE EXCEPTION 'No existeix el departament!';
    END IF;
END;
$$;

DO $$
DECLARE
    var_depId EMPLOYEES.DEPARTMENT_ID%TYPE := :vdepid;
    reg_employee RECORD;
BEGIN
    IF func_comp_dep(var_depId) THEN
        FOR reg_employee IN
            SELECT EMPLOYEES.EMPLOYEE_ID, EMPLOYEES.LAST_NAME
            FROM EMPLOYEES
            WHERE DEPARTMENT_ID = var_depId
        LOOP
            RAISE NOTICE 'Codi: %, Cognom: %', reg_employee.EMPLOYEE_ID, reg_employee.LAST_NAME;
        END LOOP;
    END IF;
END;
$$;

-- EX 3 --
CREATE OR REPLACE FUNCTION func_emps_dep (param_depId EMPLOYEES.DEPARTMENT_ID%TYPE) RETURNS SETOF EMPLOYEES language plpgsql AS $$
    DECLARE
        var_employees EMPLOYEES;

    BEGIN
        FOR var_employees IN
            SELECT *
            FROM EMPLOYEES
            WHERE DEPARTMENT_ID = param_depId
        LOOP
            RETURN NEXT var_employees;
        END LOOP;
END;$$;

-- EX 4 --
CREATE TABLE EMP_NOU_SALARY AS
   SELECT * FROM EMPLOYEES;

DO $$
    DECLARE
        curs_emps CURSOR FOR SELECT * FROM EMP_NOU_SALARY;
        reg_emps RECORD;
        var_percent NUMERIC;
    BEGIN
        OPEN curs_emps;
        LOOP
            FETCH curs_emps INTO reg_emps;
            EXIT WHEN NOT FOUND;
            update EMP_NOU_SALARY
            set salary = ROUND(salary + var_percent, 2);
            var_percent := reg_emps.SALARY * 18 / 100;
            RAISE NOTICE 'El salari antic de l`empleat % era % i el nou salari serà: %', reg_emps.LAST_NAME, reg_emps.SALARY, ROUND(reg_emps.SALARY + var_percent, 2);
        END LOOP;
        CLOSE curs_emps;
END;$$ LANGUAGE plpgsql;;

-- EX 5 --
DO $$
DECLARE
    var_depId EMP_NOU_SALARY.DEPARTMENT_ID%TYPE;
    var_commission EMP_NOU_SALARY.COMMISSION_PCT%TYPE;
    curs_emp CURSOR (param_depid EMP_NOU_SALARY.DEPARTMENT_ID%TYPE) FOR
        SELECT EMPLOYEE_ID, COMMISSION_PCT
        FROM EMP_NOU_SALARY
        WHERE DEPARTMENT_ID = param_depid;
    reg_emp RECORD;
BEGIN
    var_depId := :vdepid;

    OPEN curs_emp(var_depId);
    LOOP
        FETCH curs_emp INTO reg_emp;
        EXIT WHEN NOT FOUND;
        IF reg_emp.COMMISSION_PCT IS NOT NULL THEN
            var_commission := reg_emp.COMMISSION_PCT + 0.20;
        ELSE
            var_commission := 0;
        END IF;
        UPDATE EMP_NOU_SALARY
        SET COMMISSION_PCT = var_commission
        WHERE CURRENT OF curs_emp;
    END LOOP;
    CLOSE curs_emp;
    RAISE NOTICE 'El departament % ja no te mes empleats', var_depId;
END;$$ LANGUAGE plpgsql;

-- EX 6 --
CREATE TABLE EMP_WITH_COMISS AS
    SELECT * FROM EMPLOYEES;

DO $$
DECLARE
    var_employee EMP_WITH_COMISS;
BEGIN
    FOR var_employee IN SELECT * FROM EMP_WITH_COMISS
    LOOP
        DELETE FROM EMP_WITH_COMISS
        WHERE COMMISSION_PCT IS NULL;
    END LOOP;
END;
$$ LANGUAGE plpgsql;