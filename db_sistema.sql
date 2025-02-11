-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11/02/2025 às 13:52
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
-- Banco de dados: `db_sistema`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_clientes`
--

CREATE TABLE `tb_clientes` (
  `Id_Cliente` int(11) NOT NULL,
  `NomeCompleto` varchar(150) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Cep` varchar(9) NOT NULL,
  `Numero` varchar(5) NOT NULL,
  `Telefone` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_clientes`
--

INSERT INTO `tb_clientes` (`Id_Cliente`, `NomeCompleto`, `Cpf`, `Email`, `Cep`, `Numero`, `Telefone`) VALUES
(1, 'Vagner Lourenço', '1813458926', 'ilsdhfjklsfhd@klshdfklshdf', '654645', '6546', '65464'),
(3, 'zfdsdfsdf', '279.151.838-00', 'sdfsdf', '64654-654', '64654', '(65) 46546-644'),
(4, 'sdasd', '279.151.838-00', '1wsadd', '23131-231', '12312', '(12) 31231-231'),
(5, 'dsfsdfsdf', '279.151.838-00', 'sdfsdf', '23423-423', ' 234', '(32) 42342-342'),
(6, 'Ednaldo Pereira', '459,493,398-00', 'rfhthsbrj', '34645-677', '2134', '(19) 3957-0464');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_produtos`
--

CREATE TABLE `tb_produtos` (
  `Id` int(11) NOT NULL,
  `Proprietario` varchar(150) NOT NULL,
  `Telefone` varchar(10) NOT NULL,
  `Cpf` varchar(14) NOT NULL,
  `Placa` varchar(7) NOT NULL,
  `Modelo` varchar(150) NOT NULL,
  `Ano` year(4) NOT NULL,
  `Chassi` varchar(17) NOT NULL,
  `Cor` varchar(150) NOT NULL,
  `Marca` varchar(150) NOT NULL,
  `Acessorios` text NOT NULL,
  `Valor` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `tb_produtos`
--

INSERT INTO `tb_produtos` (`Id`, `Proprietario`, `Telefone`, `Cpf`, `Placa`, `Modelo`, `Ano`, `Chassi`, `Cor`, `Marca`, `Acessorios`, `Valor`) VALUES
(2, 'Ednaldo Pereira', '(19) 3467-', '459.493.398-00', 'efweer', 'drturi', '1995', 'dshwriktklul', 'Amarelo', 'Wolkswagen', 'ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd', 'R$123.456.789,'),
(3, 'Manoel Gomes', '(19) 3345-', '459.493.398-00', '34D5-81', '426548569', '2002', 'sdgt45u52arh58', 'Azul Caneta', 'Chevrolet', 'Caneta Azul\nAzul Caneta', 'R$600.000.000,'),
(4, 'Manoel Gomes', '(19) 3345-', '459.493.398-00', '34D5-81', '426548569', '2002', 'sdgt45u52arh58', 'Azul Caneta', 'Chevrolet', 'Caneta Azul\nAzul Caneta', 'R$600.000.000,'),
(5, 'Manoel Gomes', '(19) 3345-', '459.493.398-00', '34D5-81', '426548569', '2002', 'sdgt45u52arh58', 'Azul Caneta', 'Chevrolet', 'Caneta Azul\nAzul Caneta', 'R$600.000.000,');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  ADD PRIMARY KEY (`Id_Cliente`);

--
-- Índices de tabela `tb_produtos`
--
ALTER TABLE `tb_produtos`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_clientes`
--
ALTER TABLE `tb_clientes`
  MODIFY `Id_Cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `tb_produtos`
--
ALTER TABLE `tb_produtos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
