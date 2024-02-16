## Exercício `CalculadoraIMC`
Calcule o Índice de Massa Corporal ([IMC](https://pt.wikipedia.org/wiki/%C3%8Dndice_de_massa_corporal)) do usuário.

Exemplo:
>IMC = (Massa(peso) / (altura * altura));

![](https://wikimedia.org/api/rest_v1/media/math/render/svg/4db320ff2cde68cebea226fb921247d7ebbfad33)


Exiba a situação, conforme tabela.
Resultado | Situação
--- | ---
Abaixo de 17 | Muito abaixo do peso
Entre 17 e 18,49 | Abaixo do peso
Entre 18,5 e 24,99 | Peso normal
Entre 25 e 29,99 | Acima do peso
Entre 30 e 34,99 | Obesidade I
Entre 35 e 39,99 | Obesidade II (severa)
Acima de 40 | Obesidade III (mórbida)

Ex.:
```
- - - Calculadora de massa corporal - - -

--Digite a baixo seu peso e sua altura, por favor.

digite seu peso em Kg.: 80
digite sau altura em M: 1,84

Seu IMC é 23,63 Kg/m²   
Diagnóstico: peso normal
```
---
_William Italia_ // Curso: *_DevCs_* // Linguagem: _C#_