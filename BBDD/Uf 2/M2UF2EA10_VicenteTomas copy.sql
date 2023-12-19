-- EX 1 --
SELECT manager_id, SUM(salary)
FROM employees
GROUP BY manager_id
HAVING AVG(salary)> 3000;
-- EX 2 --
SELECT manager_id, COUNT(employee_id), MAX(salary)
FROM employees
GROUP BY manager_id
HAVING COUNT(employee_id) > 4;
-- EX 3 --
SELECT manager_id, COUNT(employee_id), MAX(salary)
FROM employees
WHERE manager_id IN (100,121,122)
GROUP BY manager_id
HAVING COUNT(employee_id) > 4;
-- EX 4 --
SELECT d.department_id, j.job_title, COUNT(e.employee_id)
FROM departments d, jobs j, employees e
GROUP BY d.department_id, j.job_title;
-- EX 5 --
SELECT d.department_name, COUNT(e.employee_id)
FROM departments d, employees e
GROUP BY department_name;
