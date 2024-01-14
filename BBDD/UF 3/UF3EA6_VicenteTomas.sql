--EJ 1 --
CREATE OR REPLACE PROCEDURE proc_alta_dept (param_Dep_id DEPARTMENTS.DEPARTMENT_ID%TYPE, param_Dep_name DEPARTMENTS.DEPARTMENT_NAME%TYPE, param_Man_Id DEPARTMENTS.MANAGER_ID%TYPE, param_Loc_Id DEPARTMENTS.LOCATION_ID%TYPE) language plpgsql as $$
    BEGIN
        INSERT INTO DEPARTMENTS VALUES (param_Dep_id, param_Dep_name, param_Man_Id, param_Loc_Id);
    END$$;

CREATE OR REPLACE FUNCTION func_compv_dept(param_dptId DEPARTMENTS.DEPARTMENT_ID%TYPE) RETURNS BOOLEAN language plpgsql as $$
DECLARE
	var_dptId DEPARTMENTS.DEPARTMENT_ID%TYPE;

BEGIN
	SELECT DEPARTMENT_ID
	INTO STRICT var_dptId
	FROM DEPARTMENTS
	WHERE DEPARTMENT_ID = param_dptId
	LIMIT 1;
	RETURN TRUE;
EXCEPTION
	WHEN SQLSTATE 'P0002' THEN
		RETURN FALSE;
END;$$;

CREATE OR REPLACE FUNCTION func_compv_mng(param_Man_Id DEPARTMENTS.MANAGER_ID%TYPE) RETURNS BOOLEAN LANGUAGE plpgsql AS $$
DECLARE
	var_manId DEPARTMENTS.MANAGER_ID%TYPE;

BEGIN
	SELECT MANAGER_ID
	INTO STRICT var_manId
	FROM DEPARTMENTS
	WHERE MANAGER_ID = param_Man_Id
	LIMIT 1;
	RETURN TRUE;
EXCEPTION
	WHEN SQLSTATE 'P0002' THEN
		RETURN FALSE;
END;
$$;

CREATE OR REPLACE FUNCTION func_compv_loc(param_loc_Id DEPARTMENTS.LOCATION_ID%TYPE) RETURNS BOOLEAN LANGUAGE plpgsql AS $$
DECLARE
	var_locId DEPARTMENTS.LOCATION_ID%TYPE;

BEGIN
	SELECT LOCATION_ID
	INTO STRICT var_locId
	FROM DEPARTMENTS
	WHERE LOCATION_ID = param_loc_Id
	LIMIT 1;
	RETURN TRUE;
EXCEPTION
	WHEN SQLSTATE 'P0002' THEN
		RETURN FALSE;
END;
$$;


DO $$
DECLARE
	var_Dep_Id DEPARTMENTS.DEPARTMENT_ID%TYPE := :vDepId;
	var_Dep_Name DEPARTMENTS.DEPARTMENT_NAME%TYPE := :vDepName;
	var_Man_Id DEPARTMENTS.MANAGER_ID%TYPE := :vManId;
	var_Loc_Id DEPARTMENTS.LOCATION_ID%TYPE := :vLocId;
BEGIN
	IF func_compv_dept(var_Dep_Id) THEN
		RAISE EXCEPTION 'YA EXISTEIX EL DEPARTAMENT!';
	ELSIF NOT func_compv_mng(var_Man_Id) THEN
	    RAISE EXCEPTION 'NO EXISTEIX CAP MANAGER AMB AQUEST ID';
	ELSIF NOT func_compv_loc(var_Loc_Id) THEN
	    RAISE EXCEPTION 'NO EXISTEIX CAP LOCACIÓ AMB AQUEST ID';
	ELSE
		RAISE NOTICE 'CREANT EL DEPARTAMENT...';
		CALL proc_alta_dept(var_Dep_Id, var_Dep_Name, var_Man_Id, var_Loc_Id);
	END IF;
END;$$ language plpgsql;

/*PRUEBAS*/
DEPARTMENT_ID | DEPARTMENT_NAME | MANAGER_ID | LOCATION_ID | RETORNO 
280           | PRUEBAS         | 114        | 1700        | Creado correctamente
270           | Prueba2         | 114        | 1700        | YA EXISTEIX EL DEPARTAMENT! 
290           | Prueba3         | 17000      | 1700        | NO EXISTEIX CAP MANAGER AMB AQUEST ID!
290           | Prueba4         | 114        | 9999999     | NO EXISTEIX CAP LOCACIÓ AMB AQUEST ID!

--EJ 2--
CREATE OR REPLACE FUNCTION func_nom_emp (param_emp_Id EMPLOYEES.EMPLOYEE_ID%TYPE) RETURNS VARCHAR LANGUAGE plpgsql AS $$
    DECLARE
        var_empNm EMPLOYEES.FIRST_NAME%TYPE;

    BEGIN
        SELECT FIRST_NAME
        INTO STRICT var_empNm
        FROM EMPLOYEES
        WHERE EMPLOYEE_ID = param_emp_Id;
        RETURN var_empNm;
END;
$$;

DO $$
    DECLARE
        var_Emp_Id EMPLOYEES.EMPLOYEE_ID%TYPE := :vempid;
    BEGIN
        RAISE NOTICE 'El nom del empleat amb id: % és: %',var_Emp_Id, func_nom_emp(var_Emp_Id);
    EXCEPTION
        WHEN SQLSTATE 'P0002' THEN
            RAISE EXCEPTION 'NO EXISTEIX CAP EMPLOYEE AMB AQUEST ID';
END;$$ language plpgsql
/*PRUEBAS*/
EMPLOYEE_ID   | RETORNO 
116           | El nom del empleat amb id: 116 és: Shelli
1             | NO EXISTEIX CAP EMPLOYEE AMB AQUEST ID

--EX 3--
CREATE OR REPLACE FUNCTION func_Dep_Name (param_dep_id DEPARTMENTS.DEPARTMENT_ID%TYPE) RETURNS VARCHAR language plpgsql AS $$
    DECLARE
        vdepId DEPARTMENTS.DEPARTMENT_NAME%TYPE;
    BEGIN
        SELECT DEPARTMENT_NAME
        INTO STRICT vdepId
        FROM DEPARTMENTS
        WHERE DEPARTMENT_ID = param_dep_id;
        RETURN vdepId;
END;$$;

DO $$
    DECLARE
        var_DepId DEPARTMENTS.DEPARTMENT_ID%TYPE := :vdep;
        var_name DEPARTMENTS.DEPARTMENT_NAME%TYPE;
    BEGIN
        var_name := func_Dep_Name(var_DepId);
        RAISE NOTICE 'Nom departament: %',func_Dep_Name(var_DepId);
        IF (UPPER(var_name) LIKE 'A%') THEN
            RAISE NOTICE 'COMENÇA PER LA LLETRA A';
        ELSE
            RAISE NOTICE 'NO COMENÇA PER LA LLETRA A';
        end if;
    EXCEPTION
        WHEN SQLSTATE 'P0002' THEN
            RAISE EXCEPTION 'ERROR: no dades';
        WHEN SQLSTATE 'P0003' THEN
            RAISE EXCEPTION 'ERROR: retorna més files';
        WHEN OTHERS THEN
            RAISE EXCEPTION 'ERROR: sense definir';
END;$$ language plpgsql
DEPARTMENT_ID   | RETORNO 
10              | El nom del departament es: Administration | COMENÇA AMB LLETRA A
100             | El nom del departament es: Finance	    | NO COMENÇA AMB LLETRA A
0				| ERROR: no dades

--EX 4--
CREATE OR REPLACE PROCEDURE proc_loc_address (param_add LOCATIONS.STREET_ADDRESS%TYPE, param_locid LOCATIONS.LOCATION_ID%TYPE) LANGUAGE plpgsql AS $$
BEGIN
    UPDATE LOCATIONS SET STREET_ADDRESS = param_add WHERE LOCATION_ID = param_locid;
END $$;

CREATE OR REPLACE FUNCTION func_comprovar_loc (param_loc_id LOCATIONS.LOCATION_ID%TYPE) RETURNS BOOLEAN LANGUAGE plpgsql AS $$
DECLARE
    vlocid LOCATIONS.LOCATION_ID%TYPE;
BEGIN
    BEGIN
        SELECT LOCATION_ID
        INTO STRICT vlocid
        FROM LOCATIONS
        WHERE LOCATION_ID = param_loc_id;

        RETURN true;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RETURN false;
    END;
END $$;

DO $$
DECLARE
    var_loc_ID LOCATIONS.LOCATION_ID%TYPE := :vLocId;
    var_loc_Add LOCATIONS.STREET_ADDRESS%TYPE := :vLocADD;
    var_exists BOOLEAN;
BEGIN
    var_exists := func_comprovar_loc(var_loc_ID);
    IF NOT var_exists THEN
        RAISE EXCEPTION 'No existeix aquest location id';
    END IF;

    CALL proc_loc_address(var_loc_Add, var_loc_ID);
END $$ LANGUAGE plpgsql;
/*PRUEBAS*/
LOCATION_ID     | STREET_ADDRESS                            | RETORNO
1000            | Prueba                                    | Departament canviat sense problemes
0               | Prueba2	                                | No existeix aquest location id
    