-- EX 1 --
SELECT e.first_name, d.department_name, e.manager_id
FROM employees e
JOIN departments d USING (department_id);

SELECT e.first_name, d.department_name, e.manager_id
FROM employees e
JOIN departments d ON d.department_id = e.department_id;
-- EX 2 --
SELECT l.city, d.department_name
FROM locations l
JOIN departments d ON l.location_id = 1400 AND d.location_id = l.location_id;

SELECT l.city, d.department_name
FROM locations l
JOIN departments d USING (location_id)
WHERE location_id = 1400;
-- EX 3 --
SELECT e.last_name, e.hire_date
FROM employees e
JOIN employees d ON d.last_name = 'Davies' AND e.hire_date > d.hire_date;
-- EX 4 --
SELECT e.first_name, e.last_name, d.department_name, l.city
FROM employees e
JOIN departments d USING (department_id) JOIN locations l USING (location_id);

SELECT e.first_name, e.last_name, d.department_name, l.city
FROM employees e
JOIN departments d ON d.department_id = e.department_id JOIN locations l ON l.location_id = d.location_id;
-- EX 5 --
SELECT e.department_id, e.last_name
FROM employees e
JOIN employees d ON e.department_id = d.department_id AND d.last_name = 'King';
