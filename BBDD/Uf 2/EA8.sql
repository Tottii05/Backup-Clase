-- EX 1 -- 
SELECT INITCAP(first_name), INITCAP(last_name) from employees;
-- EX 2 -- 
SELECT * FROM employees WHERE to_char (hire_date, 'mm') = '05';
-- EX 3 -- 
SELECT job_title FROM jobs; 
-- EX 4 --
SELECT department_id, COUNT (employee_id) FROM employees WHERE department_id IS NOT NULL GROUP BY department_id;
-- EX 5 --
SELECT job_id, COUNT (employee_id) FROM employees GROUP BY job_id;
-- EX 6 --
SELECT R.region_id, COUNT (C.country_id)
FROM countries C, regions R
WHERE C.region_id IN (1,2,3) AND R.region_id = C.region_id
GROUP BY R.region_id;
-- EX 7 --
SELECT manager_id, COUNT(employee_id), AVG(salary) FROM employees WHERE manager_id IS NOT NULL GROUP BY manager_id;
-- EX 8 --
SELECT department_id, COUNT(employee_id)
FROM employees
GROUP BY department_id
HAVING COUNT(employee_id) > 4;