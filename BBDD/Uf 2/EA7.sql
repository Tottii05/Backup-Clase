-- 1 --
select last_name, salary from employees where salary > 12000;
-- 2 --
select last_name, department_id from employees where employee_id = 176;
-- 3 --
select last_name, department_id from employees where salary not between 5000 and 12000;
-- 4 --
select last_name, job_id, hire_date from employees where hire_date between '1998-02-28' and '1998-05-1' order by hire_date ASC;
-- 5 -- 
select last_name, department_id from employees where department_id = 20 or department_id = 50 order by last_name ASC;
-- 6 --
select last_name, hire_date from employees where to_char (hire_date, 'yyyy') = '1998';
-- 7 --
select last_name, job_id from employees where manager_id is NULL;
-- 8 --
select last_name, salary, commission_pct from employees order by salary, commission_pct desc;
-- 9 --
select last_name from employees where last_name like '__a%';
-- 10 --
select last_name from employees where last_name like '%a%' or last_name like '%e%';
-- 11 -- 
select last_name, job_id, salary from employees where job_id in ('AC_ACCOUNT', 'AD_ASST') and (salary not in (2500, 3500, 7000));