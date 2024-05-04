
CREATE TABLE equipo (
  codigo int(10) unsigned NOT NULL AUTO_INCREMENT,
  numeroserie varchar(100) DEFAULT NULL,
  tipo varchar(60) DEFAULT NULL,
  nombre varchar(150) DEFAULT NULL,
  fechacompra date DEFAULT NULL,
  uso varchar(150) DEFAULT NULL,
  version varchar(50) DEFAULT NULL,
  PRIMARY KEY (codigo)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT