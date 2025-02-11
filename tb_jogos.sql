-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11/02/2025 às 15:26
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `tb_jogos`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_jogos`
--

CREATE TABLE `tb_jogos` (
  `Id_jogos` int(11) NOT NULL,
  `Titulo` varchar(150) NOT NULL,
  `Avaliacao` int(5) NOT NULL,
  `Tamanho` varchar(11) NOT NULL,
  `Descricao` text NOT NULL,
  `Valor` int(11) NOT NULL,
  `Desenvolvedor` varchar(150) NOT NULL,
  `Genero` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_jogos`
--

INSERT INTO `tb_jogos` (`Id_jogos`, `Titulo`, `Avaliacao`, `Tamanho`, `Descricao`, `Valor`, `Desenvolvedor`, `Genero`) VALUES
(1, 'Dream Game', 3, '10Mb', '', 0, 'Kenya', 'Drama'),
(2, 'Doom', 5, '2', 'xcgxczvxcvxcvxcv', 0, 'xcvxcvxcvxcv', 'Ficção ');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_jogos`
--
ALTER TABLE `tb_jogos`
  ADD PRIMARY KEY (`Id_jogos`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_jogos`
--
ALTER TABLE `tb_jogos`
  MODIFY `Id_jogos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
