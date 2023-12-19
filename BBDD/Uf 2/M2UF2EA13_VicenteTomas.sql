-- EX 1 --
select d.department_name
from departments d, employees e
where d.department_id = e.department_id
group by d.department_name
having AVG(e.salary) >= (
    select avg(salary)
    from employees
);
-- EX 2 --
select d.department_name
from departments d, employees e
where e.salary * e.commission_pct > any (
    select (e.salary * e.commission_pct)
    from employees
);
-- EX 3 --
select first_name, last_name
from departments
join employees e
where hire_date < (select hire)
-- EX 4 --
