--Ex1--
/*AMB FETCH CLOSE*/
DO $$
DECLARE
    reg_emp employees%ROWTYPE;
    emp_cursor CURSOR FOR SELECT * FROM employees;
BEGIN
    OPEN emp_cursor;

    LOOP
        FETCH emp_cursor INTO reg_emp;
        EXIT WHEN NOT FOUND;

        IF reg_emp.commission_pct IS NULL THEN
            RAISE NOTICE 'Codi: %, Nom: %, Salari: %, Comissió: 0, Data d''alta: %',
                          reg_emp.employee_id, reg_emp.first_name, reg_emp.salary, reg_emp.hire_date;
        ELSE
            RAISE NOTICE 'Codi: %, Nom: %, Salari: %, Comissió: %, Data d''alta: %',
                          reg_emp.employee_id, reg_emp.first_name, reg_emp.salary, reg_emp.commission_pct, reg_emp.hire_date;
        END IF;
    END LOOP;
    CLOSE emp_cursor;
END $$;

/*AMB FOR IN*/
DO $$
DECLARE
    reg.emp EMPLOYEES%ROWTYPE;
BEGIN
    FOR reg.emp IN SELECT * FROM employees LOOP
        IF reg_emp.commission_pct IS NULL THEN
            RAISE NOTICE 'Codi: %, Nom: %, Salari: %, Comissió: 0, Data d''alta: %', 
                          reg_emp.employee_id, reg_emp.employee_name, reg_emp.salary, reg_emp.hire_date;
        ELSE
            RAISE NOTICE 'Codi: %, Nom: %, Salari: %, Comissió: %, Data d''alta: %', 
                          reg_emp.employee_id, reg_emp.employee_name, reg_emp.salary, reg_emp.commission_pct, reg_emp.hire_date;
        END IF;
    END LOOP;
END $$;

--Ex2--
/*AMB FETCH CLOSE*/
CREATE OR REPLACE FUNCTION func_control_neg(param_salary EMPLOYEES.SALARY%TYPE) RETURNS BOOLEAN language plpgsql AS $$
    BEGIN
        IF (param_salary < 0) THEN
            RETURN true;
        ELSE
            RETURN false;
        END IF;
END;$$;

DO $$
DECLARE
    var_userSalary EMPLOYEES.SALARY%TYPE := :vsal;
    reg_salary EMPLOYEES%ROWTYPE;
    salary_cursor CURSOR FOR SELECT * FROM EMPLOYEES;
BEGIN
    IF (func_control_neg(var_userSalary)) THEN
        RAISE EXCEPTION 'ERROR: salari negatiu i ha de ser positiu';
    ELSE
        OPEN salary_cursor;

        LOOP
            FETCH salary_cursor INTO reg_salary;
            EXIT WHEN NOT FOUND;

            IF reg_salary.SALARY > var_userSalary THEN
                RAISE NOTICE 'Codi: %, Nom: %, Salari: %', reg_salary.employee_id, reg_salary.first_name, reg_salary.salary;
            END IF;
        END LOOP;
    END IF;
END $$;
/*AMB FOR IN*/
CREATE OR REPLACE FUNCTION func_control_neg(param_salary EMPLOYEES.SALARY%TYPE) RETURNS BOOLEAN language plpgsql AS $$
    BEGIN
        IF (param_salary < 0) THEN
            RETURN true;
        ELSE
            RETURN false;
        END IF;
END;$$;

DO $$
DECLARE
    var_userSalary EMPLOYEES.SALARY%TYPE := :vsal;
    reg_salary EMPLOYEES%ROWTYPE;
BEGIN
    IF (func_control_neg(var_userSalary)) THEN
        RAISE EXCEPTION 'ERROR: salari negatiu i ha de ser positiu';
    ELSE
        FOR reg_salary IN SELECT * FROM employees LOOP
            IF reg_salary.SALARY > var_userSalary THEN
                RAISE NOTICE 'Codi: %, Nom: %, Salari: %', reg_salary.employee_id, reg_salary.first_name, reg_salary.salary;
            END IF;
        END LOOP;
    END IF;
END $$; 

--Ex3--
/*AMB FETCH CLOSE*/
DO $$
DECLARE
    var_depNm DEPARTMENTS.DEPARTMENT_NAME%TYPE;
    var_depLoc DEPARTMENTS.LOCATION_ID%TYPE;
    var_depCt LOCATIONS.CITY%TYPE;
    department_cursor CURSOR FOR
        SELECT d.DEPARTMENT_NAME, d.LOCATION_ID, l.CITY
        FROM DEPARTMENTS d
        JOIN LOCATIONS l ON d.LOCATION_ID = l.LOCATION_ID;
BEGIN
    OPEN department_cursor;
    LOOP
        FETCH department_cursor INTO var_depNm, var_depLoc, var_depCt;
        EXIT WHEN NOT FOUND;
        RAISE NOTICE 'Nom departament: %, Location id: %, Ciutat: %', var_depNm, var_depLoc, var_depCt;
    END LOOP;
    CLOSE department_cursor;
END $$;

/*AMB FOR IN*/
DO $$
DECLARE
    var_depNm DEPARTMENTS.DEPARTMENT_NAME%TYPE;
    var_depLoc DEPARTMENTS.LOCATION_ID%TYPE;
    var_depCt LOCATIONS.CITY%TYPE;
    department_record RECORD;
BEGIN
    FOR department_record IN
        SELECT d.DEPARTMENT_NAME, d.LOCATION_ID, l.CITY
        FROM DEPARTMENTS d
        JOIN LOCATIONS l ON d.LOCATION_ID = l.LOCATION_ID
    LOOP
        var_depNm := department_record.DEPARTMENT_NAME;
        var_depLoc := department_record.LOCATION_ID;
        var_depCt := department_record.CITY;

        RAISE NOTICE 'Nom departament: %, Location id: %, Ciutat: %', var_depNm, var_depLoc, var_depCt;
    END LOOP;
END $$;

--Ex4--
/*AMB FETCH CLOSE*/
DO $$
DECLARE
    rec_empInfo RECORD;
    employee_cursor CURSOR FOR
        SELECT e.EMPLOYEE_ID, e.FIRST_NAME, d.DEPARTMENT_ID, d.DEPARTMENT_NAME
        FROM EMPLOYEES e
        JOIN DEPARTMENTS d ON e.DEPARTMENT_ID = d.DEPARTMENT_ID;
BEGIN
    OPEN employee_cursor;
    LOOP
        FETCH employee_cursor INTO rec_empInfo;
        EXIT WHEN NOT FOUND;

        RAISE NOTICE 'Codi empleat: %, Nom empleat: %, Codi departament: %, Nom departament: %', rec_empInfo.EMPLOYEE_ID, rec_empInfo.FIRST_NAME, rec_empInfo.DEPARTMENT_ID, rec_empInfo.DEPARTMENT_NAME;
    END LOOP;
    CLOSE employee_cursor;
END $$;
/*AMB FOR IN*/
DO $$
DECLARE
    rec_empInfo RECORD;
    employee_cursor CURSOR FOR
        SELECT e.EMPLOYEE_ID, e.FIRST_NAME, d.DEPARTMENT_ID, d.DEPARTMENT_NAME
        FROM EMPLOYEES e
        JOIN DEPARTMENTS d ON e.DEPARTMENT_ID = d.DEPARTMENT_ID;
BEGIN
    BEGIN
        OPEN employee_cursor;
        FOR rec_empInfo IN employee_cursor LOOP
            RAISE NOTICE 'Codi empleat: %, Nom empleat: %, Codi departament: %, Nom departament: %', rec_empInfo.EMPLOYEE_ID, rec_empInfo.FIRST_NAME, rec_empInfo.DEPARTMENT_ID, rec_empInfo.DEPARTMENT_NAME;
        END LOOP;
    EXCEPTION
        WHEN others THEN
            NULL;
    END;
    IF FOUND THEN
        CLOSE employee_cursor;
    END IF;
END$$;