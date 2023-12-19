-- EX 1 --
SELECT j.job_title
FROM jobs j
WHERE job_id IN (SELECT job_id FROM employees WHERE department_id = 80);
-- EX 2 --
SELECT department_name
FROM departments
WHERE department_id IN (SELECT employee_id FROM employees WHERE department_id IS NOT NULL);
-- EX 3 --
SELECT last_name
FROM employees
WHERE salary < (SELECT AVG(e.salary) FROM employees e, jobs j WHERE UPPEP(j.job_id) LIKE 'SA_MAN');
-- EX 4 --
SELECT country_name
FROM countries
WHERE region_id IN (
SELECT region_id
FROM countries
WHERE LOWER(country_name) LIKE 'argentina');
-- EX 5 --
SELECT first_name, last_name
FROM employees
WHERE job_id IN (SELECT job_id FROM employees e WHERE LOWER(first_name) LIKE 'david' AND LOWER(last_name) LIKE 'austin');
-- EX 6 --
SELECT country_name
FROM countries
WHERE region_id IN (
    SELECT region_id
    FROM regions
    WHERE LOWER(region_name) LIKE 'asia' OR LOWER(region_name) LIKE 'europe');
-- EX 7 --
SELECT last_name
FROM employees
WHERE last_name LIKE 'H%' AND salary> ANY (
    SELECT salary FROM employees WHERE department_id = 100);
-- EX 8 --
SELECT last_name
FROM employees
WHERE department_id NOT IN (
    SELECT department_id FROM departments WHERE LOWER(department_name) LIKE 'marketing' OR LOWER(department_name) LIKE 'sales');