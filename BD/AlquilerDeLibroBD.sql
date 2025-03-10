create database alquilerlibro

use alquilerlibro

CREATE TABLE alquileres (
  id_alquiler INT IDENTITY(1,1) PRIMARY KEY,
  id_usuario INT NULL,
  id_libro INT NULL,
  fecha_inicio DATE NOT NULL,
  fecha_fin DATE NOT NULL,
  estado VARCHAR(20) NOT NULL DEFAULT 'activo'
);

CREATE TABLE libros (
  id_libro INT IDENTITY(1,1) PRIMARY KEY,
  titulo VARCHAR(255) NOT NULL,
  autor VARCHAR(100) NOT NULL,
  categoria VARCHAR(50) NOT NULL,
  disponible BIT NOT NULL DEFAULT 1,
  precio_alquiler DECIMAL(5,2) NOT NULL
);

CREATE TABLE usuarios (
  id_usuario INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(100) NOT NULL,
  correo VARCHAR(100) NOT NULL UNIQUE,
  contrasena VARCHAR(255) NOT NULL,
  direccion VARCHAR(255) NULL
);

-- Agregar claves foráneas
ALTER TABLE alquileres
  ADD CONSTRAINT FK_alquileres_usuarios FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
      CONSTRAINT FK_alquileres_libros FOREIGN KEY (id_libro) REFERENCES libros(id_libro);


	  --Entrada 
	  -- Insertar usuarios
INSERT INTO usuarios (nombre, correo, contrasena, direccion)
VALUES 
    ('Juan Pérez', 'juan.perez@example.com', 'contrasena123', 'Calle 123, Santo Domingo'),
    ('María López', 'maria.lopez@example.com', 'contrasena456', 'Avenida 456, Santiago'),
    ('Carlos Gómez', 'carlos.gomez@example.com', 'contrasena789', 'Calle 789, Puerto Plata'),
    ('Ana Fernández', 'ana.fernandez@example.com', 'contrasena101', 'Avenida 101, La Romana');

-- Insertar libros
INSERT INTO libros (titulo, autor, categoria, disponible, precio_alquiler)
VALUES 
    ('El Alquimista', 'Paulo Coelho', 'Ficción', 1, 5.99),
    ('Cien Años de Soledad', 'Gabriel García Márquez', 'Realismo Mágico', 1, 7.49),
    ('1984', 'George Orwell', 'Distopía', 1, 6.99),
    ('La Sombra del Viento', 'Carlos Ruiz Zafón', 'Misterio', 1, 8.50);

-- Insertar alquileres
INSERT INTO alquileres (id_usuario, id_libro, fecha_inicio, fecha_fin, estado)
VALUES 
    (1, 1, '2025-03-01', '2025-03-10', 'activo'),
    (2, 2, '2025-03-02', '2025-03-12', 'activo'),
    (3, 3, '2025-03-03', '2025-03-13', 'activo'),
    (4, 4, '2025-03-04', '2025-03-14', 'activo');


	select * from usuarios