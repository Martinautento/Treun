# MovementDragons.cs

Este script se encarga de mover los dragones por los puntos de movimiento aleatorios. Los puntos de movimiento se definen como un array de posiciones y los dragones se moverán hacia esos puntos de manera aleatoria. Se utiliza en Unity para controlar el movimiento de los dragones en el juego.

## Variables

- `public float velocidadMovimiento=1`: Una variable pública que representa la velocidad de movimiento de los dragones. Inicializada en 1.

- `public Transform[] puntosMovimiento`: Un array de Transform que representa los puntos de movimiento hacia los cuales se desplazarán los dragones.

- `public float distanciaMinima=0.2f`: Una variable pública que representa la distancia mínima a la cual un dragón debe estar de un punto de movimiento para considerarlo alcanzado. Inicializada en 0.2 unidades.

- `private int numeroAleatorio`: Una variable privada que almacena un número aleatorio generado para seleccionar un punto de movimiento del array `puntosMovimiento`.

- `private SpriteRenderer spriterenderer`: Una variable privada que almacena el componente SpriteRenderer asociado al objeto del dragón.

## Métodos

- `void Start()`: Método que se llama una vez al inicio. Genera un número aleatorio para seleccionar un punto de movimiento del array `puntosMovimiento`, obtiene el componente SpriteRenderer adjunto al objeto del dragón y llama al método `Girar()` para establecer la dirección de mirada inicial del dragón.

- `void Update()`: Método que se llama una vez por fotograma. Mueve el objeto del dragón hacia el punto de movimiento actual con una velocidad determinada. Comprueba si el objeto ha llegado al punto de movimiento actual y, si es así, genera un nuevo número aleatorio para seleccionar un nuevo punto de movimiento y llama al método `Girar()` para actualizar la dirección de mirada del dragón.

- `private void Girar()`: Método privado que se encarga de girar el objeto del dragón en función de su posición y el punto de movimiento actual. Comprueba si la posición del objeto es menor que la posición del punto de movimiento actual en el eje x y, dependiendo de esta comparación, voltea horizontalmente el SpriteRenderer para que el objeto mire hacia la derecha o no voltea para que el objeto mire hacia la izquierda.

## Funcionamiento

Este script se debe adjuntar a los objetos que representan a los dragones en Unity. Cada dragón se moverá hacia los puntos de movimiento definidos en el array `puntosMovimiento`. En cada actualización de fotograma, el dragón se moverá hacia el punto de movimiento actual con una velocidad determinada. Una vez que el dragón alcance el punto de movimiento actual (a una distancia menor que `distanciaMinima`), generará un nuevo número aleatorio para seleccionar un nuevo punto de movimiento. La dirección de mirada del dragón se actualizará para que mire hacia la dirección del nuevo punto de movimiento. Esto permitirá que los dragones se muevan de manera aleatoria por los puntos de movimiento en el juego.











<p align="center">
  <img src="/Imagenes/Logo_LunaGhost.png" alt="LunaGhost" width="100" height="100">
  **Documentado por Luna Acosta**
</p>