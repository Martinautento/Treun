# AumentarContador.cs

Este script aumenta el contador de dragones y muestra un menú de victoria cuando alcanza el valor de 100.

## Variables

- `int x`: Una variable entera que actúa como contador de dragones. Se inicializa en 0.

- `Text textoContador`: Una variable que representa un componente de texto en Unity. Se utiliza para mostrar el contador en la interfaz de usuario.

- `GameObject menuVictory`: Este objeto corresponde al menú de victoria que se mostrará cuando el contador alcance 100.

## Métodos

- `Start()`: Método que se llama una vez al inicio del juego. Obtiene el componente de texto adjunto al objeto y lo asigna a la variable `textoContador`.

- `ActivarYouWIN()`: Método privado que activa el objeto "menuVictory" y detiene el tiempo en el juego estableciendo Time.timeScale en 0 (pausa). Esto despliega el menú de victoria cuando se llama.

- `Update()`: Método que se llama cada cuadro del juego. Actualiza el contador mostrado en el componente de texto `textoContador`. Si el valor de `x` es menor que 100, muestra el valor actual de `x` concatenado con "/100". Si el valor de `x` es igual o mayor a 100, establece el texto en "100/100" y llama al método `ActivarYouWIN()` para mostrar el menú de victoria.

## Funcionamiento

Este script se puede adjuntar a un objeto en Unity y se ejecutará automáticamente durante el juego. Cada vez que se llama al método `Update()`, se verifica si el contador `x` es menor que 100. Si es menor, el texto del componente `textoContador` mostrará el valor actual de `x`. Cuando el contador `x` llega a 100 o más, se muestra el menú de victoria y el tiempo del juego se detiene.








<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
  **Documentado por Luna Acosta**
</p>