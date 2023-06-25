"# crs-pltz-Solid-Principles" 

1. ¿Qué son las buenas prácticas y el código limpio?>

Buenas prácticas (Best practices)

Nos permiten resolver conflictos de escenarios comunes.
Brindan guías que son sencillas de comprender, aprender y aplicar.
Permiten contar con una estructura similar para múltiples proyectos.
Diferencia entre buenas prácticas y estándares

Las buenas prácticas ya están comprobadas; pues han sido utilizadas muchas veces y esto comprueba su funcionalidad. Estas ayudan a tener un mejor código, arquitectura y a comprender fácilmente el código.
Código limpio- Clean code

Se refiere a buenas prácticas dirigidas al código.
Es fácil de entender, analizar, mantener, actualizar y escalar.

2. ¿Cómo lograr código limpio?

Algunas reglas a seguir son:

Mantener bajo acoplamiento. Se busca que no exista dependencia entre componentes.
Uso de sintaxis simple y actual.
Evitar incorporar muchas librerías de terceros. Para evitar dependencias y mantener el control del código.
Distribución de responsabilidades. Cada componente debe contar con una sola responsabilidad específica.
Crear componentes pequeños.

CLEAN CODE (recommended book)

What is SOLID?

S.O.L.I.D

S = Sigle responsibility principle - Principio de responsabilidad única.
O = Open/closed principle - Principio abierto-cerrado.
L = Liskov substitution principle - Principio de sustitución de Liskov.
I = Interface segregation principle - Principio de segregación de interfaz.
D = Dependency inversion principle -Principio de inversión de dependencia.

S. Single responsibility principle-Principio de responsabilidad única.

Debemos asignar una única responsabilidad a cada uno de los componentes.

O. Open/closed principle- Principio de abierto/cerrado.

El código debe estar abierto a extensiones y cerrado a cambios.

L. Liskov substitution principle-Principio de sustitución de Liskov.

Relación entre tipos y subtipos dentro del sistema.

I. Interface segregation principle- Principio de segregación de la interfaz

Ayuda a asignar una responsabilidad específica a cada una de las interfaces que tiene el sistema.

D. Dependency inversion principle- Principio de inversión de la dependencia.

Inyección de dependencias y el evitar el acoplamiento.

Example:

Como usuario luego de confirmar la compra espero ver un <span style="background:#0e6631"> mensaje de confirmación </span>, tener la posibilidad de <span style="background:#0e6631"> descargar la factura </span> y un <span style="background:#0e6631"> correo electrónico de confirmación </span>.

este es un feature al cual le podemos implementar el principio de responsabilidad unica ya que es una feature a la cual tiene varias funcionalidades las cuales separaremos para darle una responsabilidad unica a cada funcionalidad 

1. mensaje de confirmación
2. descargar la factura
3. correo electrónico de confirmación

las cuales seran usadas para resolver este feature