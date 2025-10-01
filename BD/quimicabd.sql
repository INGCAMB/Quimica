CREATE TABLE `historial` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `examen` text NOT NULL,
  `calificacion` int(11) NOT NULL,
  `fecha` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

CREATE TABLE `preguntasbalanceo` (
  `id` int(11) NOT NULL,
  `preg` varchar(200) NOT NULL,
  `a` varchar(100) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `correcta` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `preguntasdificil` (
  `id` int(11) NOT NULL,
  `preg` varchar(200) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(100) NOT NULL,
  `c` varchar(100) NOT NULL,
  `d` varchar(100) NOT NULL,
  `Correcta` varchar(100) NOT NULL,
  `Explicacion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `preguntasquimico` (
  `id` int(11) NOT NULL,
  `preg` varchar(600) NOT NULL,
  `a` varchar(200) NOT NULL,
  `b` varchar(200) NOT NULL,
  `correcta` varchar(200) NOT NULL,
  `explicacion` varchar(350) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `contra` varchar(50) NOT NULL,
  `admin` tinyint(1) NOT NULL,
  `maestro` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `historial`
  ADD PRIMARY KEY (`id`);
ALTER TABLE `preguntasbalanceo`
  ADD PRIMARY KEY (`id`);
ALTER TABLE `preguntasdificil`
  ADD PRIMARY KEY (`id`);
ALTER TABLE `preguntasquimico`
  ADD PRIMARY KEY (`id`);
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

ALTER TABLE `historial`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
ALTER TABLE `preguntasbalanceo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
ALTER TABLE `preguntasdificil`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
ALTER TABLE `preguntasquimico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;
COMMIT;

