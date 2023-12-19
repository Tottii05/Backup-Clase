/*Escriu un programa PL/SQL que introduirem per teclat dos números. Els dos números han
de ser positius, en cas contrari s’ha de mostrar a l’usuari el missatge corresponent. S’ha de realitzar la
següent operació amb aquests números: dividir entre ells i sumar-li el segon i mostrar el resultat de
l'operació.*/
DO $$
DECLARE
    firstNum numeric := :n1;
    secondNum numeric := :n2;
    divideNum numeric;
    totalSum numeric;
BEGIN
    if firstNum <= 0 or secondNum <= 0 then
        if firstNum <= 0 then
            raise notice 'El primer número no es natural';
        elsif secondNum <= 0 then
            raise notice 'El segundo número no es natural';
        end if;
    else
        divideNum := firstNum / secondNum;
        totalSum := divideNum + secondNum;
        raise notice 'La suma de los dos números es %', totalSum;
    end if;
END
$$;

/*Escriu el mateix programa PL/SQL de l’exercici 1, però ara també s’ha de controlar que el
primer número sigui més gran que el segon. En cas contrari s’ha de mostrar el següent missatge:
‘Error! el primer número ha de ser més gran que el segon’.*/
DO $$
DECLARE
    firstNum numeric := :n1;
    secondNum numeric := :n2;
    divideNum numeric;
    totalSum numeric;
BEGIN
    if firstNum <= 0 or secondNum <= 0 then
        if firstNum <= 0 then
            raise notice 'El primer número no es natural';
        elsif secondNum <= 0 then
            raise notice 'El segundo número no es natural';
        end if;
    elsif firstNum < secondNum then
        raise notice 'Error! El primer número tiene que ser más grande que el segundo';
    else
        divideNum := firstNum / secondNum;
        totalSum := divideNum + secondNum;
        raise notice 'La suma de los dos números es %', totalSum;
    end if;
END
$$;

/*Escriu un programa PL/SQL que demani a l’usuari la seva edat i mostri el missatge
corresponent, si:
a) Entre 0 i 17 mostres 'Ets menor de edat!'
b) Entre 18 i 40 mostres 'Ja ets major de edat!'
d) > 40 mostres 'ja ets força gran'
e) Si és negatiu (<0) mostres 'L ́edat no pot ser negativa'.*/
DO $$
DECLARE
    age numeric =: edad;
BEGIN
    if age < 0 then
        raise notice 'La edad no puede ser negativa!';
    elsif age = 0 and age < 18 then
        raise notice 'Eres menor de edad!';
    elsif age >= 18 and age < 41 then
            raise notice 'Ya eres mayor de edad!';
    elsif age > 40 then
        raise notice 'Ya eres bastante mayor';
    end if;
END
$$;

/*Escriu un programa PL/SQL que demani quina operació es farà:
opció 1 SUMAR, opció 2 RESTAR, opció 3 MULTIPLICAR, opció 4 DIVIDIR .
Després el programa també demana dos números i ha de realitzar la operació escollida amb els dos
números introduits per teclat. S’ha de mostrar l’operació escollida, els números introduïts i el resultat.*/
DO $$
DECLARE
    num1 numeric =: número1;
    num2 numeric =: número2;
    choice numeric =: opción;
    result numeric;
BEGIN
    case choice
        when 1 then result = num1 + num2;
        when 2 then result = num1 - num2;
        when 3 then result = num1 * num2;
        when 4 then result = num1 / num2;
    end case;
    raise notice '%', result;
END
$$;

/*Escriu un programa PL/SQL que ens mostri els números entre un rang. El rang mínim és 1
i el màxim se li ha de preguntar a l’usuari i no pot ser menor que 2. Si no és 2 o més gran es mostra un
missatge a l'usuari i finalitza el programa.
a. Utilitza l’estructura FOR.
b. Utilitza l’estructura WHILE.*/
DO $$
DECLARE
    max numeric =: máximo;
BEGIN
    if max < 2 then
        raise notice 'El segundo valor no puede ser menor que 2';
    else
        for i in 1 .. max loop
            raise notice '%', i;
        end loop;
    end if;
END
$$;

DO $$
DECLARE
    max numeric =: máximo;
    i numeric := 1;
BEGIN
    if max < 2 then
        raise notice 'El segundo valor no puede ser menor que 2';
    else
        while i <= max loop
            raise notice '%',i;
            i := i+1;
        end loop;
    end if;
END
$$;

/*Escriu un programa PL/SQL que mostri els números entre un rang amb un salt. Tant el
rang mínim, com el màxim i el salt se li ha de preguntar a l’usuari. A més, s’ha de tenir en compte
que el rang mínim sempre ha de ser més petit que el rang màxim i que el el salt ha de ser més gran
que 1. En cas contrari s’ha de mostrar el missatge corresponent i acabar el programa.*/
DO $$
DECLARE
    min numeric;
    max numeric;
    jump numeric;
    i numeric;
BEGIN
    min =: mínimo;
    max =: máximo;
    jump =: salto;
    if min >= max then
        raise notice 'El valor mínimo no puede ser mayor o igual que el máximo';
    end if;
    if jump < 1 then
        raise notice 'El valor de salto no puede ser menor que 1';
    end if;
    i := min;
    while i <= max loop
        raise notice '%', i;
        i := i + jump;
    end loop;
END
$$;
