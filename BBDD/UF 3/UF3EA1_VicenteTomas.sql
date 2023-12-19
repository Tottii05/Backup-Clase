/*Crea un bloc anònim que ha d'imprimir el cognom de l'empleat en majúscules amb codi
número 104 de la taula (EMPLOYEES), on has de declarar una variable de tipus last_name.*/
do $$
DECLARE
    cognom EMPLOYEES.LAST_NAME%TYPE;
BEGIN
	SELECT last_name
	into cognom
	from employees
	where employee_id = 104;
  raise notice 'El cognom és %', upper(cognom);
end;
$$ 

/*Crea un bloc anònim que ha d'imprimir el cognom de l'empleat en majúscules del id de
l’empleat introdueixi per pantalla.*/
do $$
DECLARE
    cognom EMPLOYEES.LAST_NAME%TYPE;
BEGIN
	SELECT salary
	into cognom
	from employees
	where employee_id = 120;
  raise notice 'El salary del empleat amb id 120 és %', salary;
end;
$$

/*Crea un bloc anònim amb variables PL/SQL que mostri el salari de l'empleat amb id=120, has
de declarar una variable de tipus salary.*/
do $$
DECLARE
    salario EMPLOYEES.salary%TYPE;
BEGIN
	SELECT salary
	into salario
	from employees
	where employee_id = 120;
  raise notice 'El salary del empleat amb id 120 és %', salario;
end;
$$

/*Crea un bloc anònim amb una variable PL/SQL que imprimeixi el salari més alt dels
treballadors que treballen al departament 'SALES'.*/
do $$
DECLARE
    salario EMPLOYEES.salary%TYPE;
BEGIN
	SELECT max(salary)
	into salario
	from employees
	join departments d using (department_id)
	where lower(d.department_name) = 'sales';
  raise notice 'El salari més alt del departament sales és %', salario;
end
$$

/*Crea un bloc anònim amb tre variables de tipus NUMBER. Aquestes variables
han de tenir un valor inicial de 15, 40 i 35 respectivament. El bloc ha de sumar aquestes tres variables i
mostrar per pantalla ‘LA SUMA TOTAL ÉS: (la suma de les variables)’.*/
do $$
DECLARE
    firstNum numeric = 15;
    secondNum numeric = 40;
    thirdNum numeric = 35;
    totalSum numeric = firstNum + secondNum + thirdNum;
BEGIN
  raise notice 'La suma de 15, 40 i 35 és %', totalSum;
end
$$
