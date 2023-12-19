-- EX 1 --
SELECT E.*, J.job_title
FROM employees E, jobs J 
WHERE J.job_title = 'Sales Manager';
-- EX 2 --
SELECT D.department_name
FROM departments D, job_history JH
WHERE to_char (JH.end_date, 'yyyy') = '1998'
GROUP BY D.department_name;
-- EX 3 --
SELECT D.department_name
FROM departments D, employees E
WHERE (E.first_name LIKE 'A%')
GROUP BY D.department_name;
-- EX 4 --
SELECT D.department_name, E.first_name, E.last_name
FROM departments D, employees E
WHERE D.department_name NOT LIKE 'IT';
-- EX 5 --
SELECT D.*, L.city
FROM departments D, locations L
WHERE L.city LIKE 'Seattle';
-- EX 6 --
SELECT E.first_name, E.last_name, D.department_name, L.city
FROM employees E, departments D, locations L
WHERE L.city LIKE 'Seattle';
-- EX 7 --
SELECT D.department_name, E.*
FROM departments D, employees E
WHERE D.department_name NOT LIKE 'Marketing' OR D.department_name NOT LIKE 'Sales';
-- EX 8 --
SELECT D.department_name, L.city, C.country_name
FROM departments D, locations L, countries C
WHERE L.country_id = C.country_id; 
-- EX 9 --
SELECT C.country_name, R.region_name, R.region_id
FROM countries C, regions R
WHERE C.region_id = R.region_id AND (R.region_id = 1 OR R.region_id = 3)
ORDER BY R.region_name;
-- EX 10 --
SELECT e.last_name, e.job_id, m.first_name
FROM employees e, employees m
WHERE e.manager_id = m.employee_id AND e.job_id = m.job_id;
-- EX 11 --
SELECT e.last_name, m.first_name, j.job_title
FROM employees e, employees m, jobs j
WHERE e.manager_id = m.employee_id AND e.job_id = m.job_id;