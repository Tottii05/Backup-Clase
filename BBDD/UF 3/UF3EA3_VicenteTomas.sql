/*Realitzar un programa que contingui una funció que dupliqui la quantitat rebuda com a
paràmetre. La funció rebrà el nom de FUNC_DUPLICAR_QUANTITAT. S’ha de programar un bloc
principal que demani per teclat la quantitat i que cridi a la funció FUNC_DUPLICAR_QUANTITAT
passant el paràmetre corresponent.*/
create or replace function FUNC_DUPLICAR_QUANTITAT(num integer)
returns integer as
$$
declare
    final integer;
begin
    final := num * 2;
    return final;
end
$$
language plpgsql;
DO $$
DECLARE
    num integer;
BEGIN
    num =: número;
    raise notice '%', FUNC_DUPLICAR_QUANTITAT(num);
END
$$;

/*Realitzar un programa que contingui una funció que calculi el factorial d’un número que
es passa com a paràmetre. La funció rebrà el nom de FUNC_FACTORIAL. S’ha de programar un
bloc principal que pregunti a l’usuari pel número a calcular i cridi a la funció FUNC_FACTORIAL,
passant el paràmetre corresponent.*/