-- -----------------------------------------------------
-- Table `sysManager`.`unity`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS sysManager.unity (
  `id` CHAR(36) not null default 'uuid()' comment 'Identificador do registro',
  `name` varchar(100) not null comment 'Nome do Unidade de produto',
  `active` bit NOT NULL default false comment 'Ativo ou inativo',
  `createdDate` datetime not null default NOW() comment 'data de cria��o do registro',
  `updatedDate` datetime null  comment 'data de atualiza��o do registro',
  PRIMARY KEY (`id`)
  );