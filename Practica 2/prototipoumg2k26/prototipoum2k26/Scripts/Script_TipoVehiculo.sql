Create database sistema_reparto
use sistema_reparto

CREATE TABLE `tipo_vehiculo` (
  `id_tipo_vehiculo` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_vehiculo` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_tipo_vehiculo` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_tipo_vehiculo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;