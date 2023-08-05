# PowerUps.cs

Este script controla el comportamiento de los objetos que representan los Power-Ups en el juego. Los Power-Ups son objetos que el jugador puede recoger para obtener beneficios temporales o desencadenar acciones específicas.

## Variables

- `private AudioSource audioSource`: Una variable privada que almacena el componente AudioSource asociado al objeto del Power-Up para reproducir sonidos.

## Métodos

- `private void Start()`: Método que se llama una vez al inicio. Obtiene el componente AudioSource asociado al objeto del Power-Up.

- `private void OnTriggerEnter2D(Collider2D collision)`: Método que se llama cuando el objeto del Power-Up entra en contacto con otro objeto con colisiones habilitadas. Comprueba si el objeto colisionado tiene la etiqueta "Player" o "Finish" y realiza acciones en consecuencia.

## Funcionamiento

Este script debe ser adjuntado a los objetos que representan los Power-Ups en Unity. Cuando un objeto del Power-Up entra en contacto con el jugador (etiquetado como "Player"), se desactiva visualmente (el SpriteRenderer se oculta), se reproduce un sonido mediante el componente AudioSource asociado y, después de 0.3 segundos, el objeto del Power-Up es destruido. Esto simula la recogida del Power-Up por parte del jugador. Si el objeto del Power-Up entra en contacto con un objeto etiquetado como "Finish", simplemente se desactiva visualmente y se destruye después de 0.3 segundos, lo que representa una acción específica del Power-Up en ese contexto del juego.











<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
  **Documentado por Luna Acosta**
</p>