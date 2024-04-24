create database unclepiston
use unclepiston


CREATE TABLE ������������ (
    ID_������������ INT PRIMARY KEY IDENTITY,
    �����_������������ VARCHAR(255),
    ������_������������ VARCHAR(255),
    ����� BIT DEFAULT 0,
    ��������� BIT DEFAULT 0,
    ������������ BIT DEFAULT 0
);

CREATE TABLE ���������� (
  ID_���������� INT PRIMARY KEY,
  ��������_���������� VARCHAR(255),
  ����� VARCHAR(255),
  ������� VARCHAR(20)
);

CREATE TABLE �������� (
  ID_�������� INT PRIMARY KEY,
  ��������_�������� VARCHAR(255),
  ������������� VARCHAR(255),
  ���� DECIMAL(10, 2),
  ID_���������� INT,
  FOREIGN KEY (ID_����������) REFERENCES ����������(ID_����������)
);

CREATE TABLE ������� (
  ID_������� INT PRIMARY KEY,
  ������� VARCHAR(255),
  ��� VARCHAR(255),
  �������� VARCHAR(255),
  ����� VARCHAR(255),
  ������� VARCHAR(20)
);

CREATE TABLE ������ (
  ID_������ INT PRIMARY KEY,
  ����_������ DATE,
  ID_������� INT,
  ID_������� INT,
  ID_���������� INT,
  ������_������ varchar(255),
  FOREIGN KEY (ID_�������) REFERENCES �������(ID_�������),
  FOREIGN KEY (ID_����������) REFERENCES ����������(ID_����������),
  FOREIGN KEY (ID_�������) REFERENCES ������_������(ID_�������),
);

CREATE TABLE ������_������ (
  ID_������_������ INT PRIMARY KEY,
  ID_������ INT,
  ������_������ varchar(255),
  ���������_������ varchar(255),
  �����_�����������_������ varchar(255),
  ����_��������� varchar(255),
  �������� VARCHAR(255),
  FOREIGN KEY (ID_������) REFERENCES ������( ID_������)
);

CREATE TABLE ����� (
  ID_������ INT PRIMARY KEY,
  ID_�������� INT,
  ���������� INT,
  FOREIGN KEY (ID_��������) REFERENCES ��������(ID_��������)
);


CREATE TABLE ������� (
  ID_������� INT PRIMARY KEY,
  ID_������ INT,
  ����_������� DATE,
  ����� DECIMAL(10, 2),
  FOREIGN KEY (ID_������) REFERENCES ������(ID_������)
);


CREATE TABLE ������_������ (
  ID_������� INT PRIMARY KEY,
  ID_�������� INT,
  ���������� INT,
  FOREIGN KEY (ID_��������) REFERENCES ��������(ID_��������)
);

CREATE TABLE ���������� (
  ID_���������� INT PRIMARY KEY,
  ID_users INT,
  ID_������������ INT,
  ������� VARCHAR(255),
  ��� VARCHAR(255),
  �������� VARCHAR(255),
  ����_����� VARCHAR(255),
  ��������� VARCHAR(255),
  �������� DECIMAL(10, 2),
  FOREIGN KEY (ID_������������) REFERENCES ������������(ID_������������)
);




INSERT INTO ������� (ID_�������, �������, ���, ��������, �����, �������) VALUES
(1, '�������', '���������', '�������������', '������ �����, �������� ���, ������ ��.', '+7 (123) 456-7890'),
(2, '�������', '������', '���������', '������� ����� � �������� �����', '+7 (234) 567-8901'),
(3, '��������', '�����', '�������������', '��. ��������, �.30, ��. 25', '+7 (345) 678-9012'),
(4, '������', '�������', '����������', '��. ��������, �.40, ��. 35', '+7 (456) 789-0123'),
(5, '��������', '�����', '��������', '��. ������, �.50, ��. 45', '+7 (567) 890-1234'),
(6, '��������', '������', '��������', '��. ������������, �.60, ��. 55', '+7 (678) 901-2345'),
(7, '��������', '�������', '����������', '��. ������, �.70, ��. 65', '+7 (789) 012-3456'),
(8, '���������', '���������', '���������', '��. �������, �.80, ��. 75', '+7 (890) 123-4567'),
(9, '�������', '��������', '������������', '��. ������, �.90, ��. 85', '+7 (901) 234-5678'),
(10, '�������', '�������', '����������', '��. ������, �.100, ��. 95', '+7 (012) 345-6789'),
(11, '��������', '������', '��������', '��. ������, �.110, ��. 105', '+7 (123) 456-7890'),
(12, '������', '���������', '�������������', '��. ����������, �.120, ��. 115', '+7 (234) 567-8901'),
(13, '��������', '���������', '��������', '��. �������, �.130, ��. 125', '+7 (345) 678-9012'),
(14, '�������', '�������', '����������', '��. ����������, �.140, ��. 135', '+7 (456) 789-0123'),
(15, '�������', '�����', '��������', '��. ��������, �.150, ��. 145', '+7 (567) 890-1234'),
(16, '���������', '������', '������������', '��. ��������, �.160, ��. 155', '+7 (678) 901-2345'),
(17, '�������', '������', '������������', '��. ������������, �.170, ��. 165', '+7 (789) 012-3456'),
(18, '���������', '�����', '�������������', '��. ������, �.180, ��. 175', '+7 (890) 123-4567'),
(19, '�������', '����', '��������', '��. ��������, �.190, ��. 185', '+7 (901) 234-5678'),
(20, '������', '�����', '����������', '��. �������, �.200, ��. 195', '+7 (012) 345-6789');


INSERT INTO ������������ (�����_������������, ������_������������, ����_������������) VALUES
('JohnDoe', 'password123', 'admin'),
('JaneSmith', 'qwerty123', 'user'),
('AlexKozlov', 'password', 'user'),
('MariaIvanova', 'abc123', 'user'),
('AndrewPavlov', 'password456', 'user'),
('OlgaSidorova', 'securepass', 'user'),
('DmitryNikolaev', 'userpass', 'user'),
('NatalieVasileva', '123456', 'user'),
('SergeyZaitsev', 'password123', 'user'),
('KateKuznetsova', 'pass1234', 'user');


INSERT INTO ���������� (ID_����������, ��������_����������, �����, �������) VALUES
(1, '����������', '��. �������, �. 10', '+7 (123) 456-7890'),
(2, '��������24', '��. ������, �. 25', '+7 (234) 567-8901'),
(3, '������������', '��. ��������, �. 5', '+7 (345) 678-9012'),
(4, '��������', '��. ����, �. 15', '+7 (456) 789-0123'),
(5, '�����������������', '��. ���������, �. 30', '+7 (567) 890-1234'),
(6, '��������', '��. ������, �. 20', '+7 (678) 901-2345'),
(7, 'AutoParts', '��. ����������, �. 8', '+7 (789) 012-3456'),
(8, '�����������', '��. ������, �. 12', '+7 (890) 123-4567'),
(9, '��������������', '��. ���������, �. 18', '+7 (901) 234-5678'),
(10, '�����������������', '��. ������, �. 22', '+7 (012) 345-6789'),
(11, '�����������', '��. ������������, �. 6', '+7 (123) 456-7890'),
(12, '�������������', '��. ��������, �. 28', '+7 (234) 567-8901'),
(13, '������������24', '��. ��������, �. 7', '+7 (345) 678-9012'),
(14, '��������������', '��. ������, �. 14', '+7 (456) 789-0123'),
(15, 'AutoPartsExpress', '��. �������, �. 4', '+7 (567) 890-1234'),
(16, '���������', '��. ������� �����, �. 9', '+7 (678) 901-2345'),
(17, '�������������������', '��. ������, �. 16', '+7 (789) 012-3456'),
(18, '���������������', '��. �����������, �. 3', '+7 (890) 123-4567'),
(19, '����������������', '��. ����������, �. 11', '+7 (901) 234-5678'),
(20, '���������', '��. ����������, �. 2', '+7 (012) 345-6789');

INSERT INTO �������� (ID_��������, ��������_��������, �������������, ����, ID_����������) VALUES
(1, '��������� �������', 'Bosch', 2500, 1),
(2, '������ ��������', 'Mann-Filter', 800, 2),
(3, '�����������', 'Varta', 5000, 3),
(4, '����� ���������', 'NGK', 600, 4),
(5, '������� �����', 'Febi', 1500, 5),
(6, '������ ���', 'ContiTech', 3000, 6),
(7, '������ ������������', 'Monroe', 4000, 7),
(8, '������ ���������', 'Hengst', 1000, 8),
(9, '��������� �����', 'Bosch', 7000, 9),
(10, '����� ���������', 'Brembo', 3500, 10),
(11, '��������� ���', 'Elring', 2000, 11),
(12, '��������� �������', 'SKF', 2500, 12),
(13, '������ ������', 'Mann-Filter', 1200, 13),
(14, '����� ��������', 'Lemforder', 1800, 14),
(15, '�������� ����������', 'Valeo', 6000, 15),
(16, '����� �����������', 'Beru', 1500, 16),
(17, '���������������', 'Garrett', 10000, 17),
(18, '���������', 'Behr', 2500, 18),
(19, '���� ��������', 'Depo', 3000, 19),
(20, '������ ������', 'TYC', 2000, 20);

INSERT INTO ���������� (ID_����������, ID_users, ID_������������, �������, ���, ��������, ����_�����, ���������, ��������) VALUES
(1, 1, 1, '������', '����', '��������', '2023-01-15', '�������� �� ��������', 30000),
(2, 2, 2, '������', 'ϸ��', '��������', '2023-02-20', '�������', 35000),
(3, 3, 3, '�������', '�����', '���������', '2023-03-25', '���������', 40000),
(4, 4, 4, '������', '�����', '��������', '2023-04-30', '�������� �� ��������', 32000),
(5, 5, 5, '��������', '�������', '����������', '2023-05-05', '���������� �� ����������� ���������', 38000),
(6, 6, 6, '��������', '�������', '����������', '2023-06-10', '������ �� ������� ����������', 45000),
(7, 7, 7, '��������', '�������', '����������', '2023-07-15', '��������� ��������', 28000),
(8, 8, 8, '��������', '�������', '����������', '2023-08-20', '�����������', 35000),
(9, 9, 9, '�������', '������', '���������', '2023-09-25', '�������� �� ���������', 32000),
(10, 10, 10, '�������', '������', '���������', '2023-10-30', '����������� ��������', 55000),
(11, 11, 5, '������', '�����', '��������', '2023-11-05', '��������-�����������', 30000),
(12, 12, 2, '�����', '����', '�������', '2023-12-10', '��������', 40000),
(13, 13, 3, '�������', '�����', '���������', '2024-01-15', '�������� �� ��������', 32000),
(14, 14, 4, '��������', '������', '����������', '2024-02-20', '���������� �� ������������ ������������', 38000),
(15, 15, 5, '�������', '�����', '���������', '2024-03-25', '����������� �� �������', 35000),
(16, 16, 6, '������', '����', '��������', '2024-04-30', '������ �� ��������� �������', 45000),
(17, 17, 7, '��������', '�������', '����������', '2024-05-05', '�������� call-������', 28000),
(18, 18, 8, '��������', '�������', '����������', '2024-06-10', '������� �������', 38000),
(19, 19, 9, '�������', '������', '���������', '2024-07-15', '����������� ����������', 32000),
(20, 20, 4, '�������', '�����', '���������', '2024-08-20', '�����������', 55000);

INSERT INTO ������_������ (ID_�������, ID_��������, ����������) VALUES
(1, 1, 3),
(2, 2, 5),
(3, 3, 2),
(4, 4, 1),
(5, 5, 4),
(6, 6, 2),
(7, 7, 3),
(8, 8, 6),
(9, 9, 1),
(10, 10, 2),
(11, 11, 4),
(12, 12, 3),
(13, 13, 2),
(14, 14, 1),
(15, 15, 5),
(16, 16, 3),
(17, 17, 2),
(18, 18, 4),
(19, 19, 1),
(20, 20, 2);

INSERT INTO ������ (ID_������, ����_������, ID_�������, ID_�������, ID_����������, ������_������) VALUES
(1, '2023-01-15', 1, 1, 1, '� ���������'),
(2, '2023-02-20', 2, 2, 2, '��������'),
(3, '2023-03-25', 3, 3, 3, '������� ������'),
(4, '2023-04-30', 4, 4, 4, '� ���������'),
(5, '2023-05-05', 5, 5, 5, '��������'),
(6, '2023-06-10', 6, 6, 6, '������� ��������'),
(7, '2023-07-15', 7, 7, 7, '� ���������'),
(8, '2023-08-20', 8, 8, 8, '������� ������'),
(9, '2023-09-25', 9, 9, 9, '��������'),
(10, '2023-10-30', 10, 10, 10, '� ���������'),
(11, '2023-11-05', 11, 11, 11, '������� ������'),
(12, '2023-12-10', 12, 12, 12, '��������'),
(13, '2024-01-15', 13, 13, 13, '� ���������'),
(14, '2024-02-20', 14, 14, 14, '������� ��������'),
(15, '2024-03-25', 15, 15, 15, '��������'),
(16, '2024-04-30', 16, 16, 16, '������� ������'),
(17, '2024-05-05', 17, 17, 17, '� ���������'),
(18, '2024-06-10', 18, 18, 18, '��������'),
(19, '2024-07-15', 19, 19, 19, '������� ������'),
(20, '2024-08-20', 20, 20, 20, '��������');

INSERT INTO ������� (ID_�������, ID_������, ����_�������, �����) VALUES
(1, 1, '2023-01-20', 7500),
(2, 2, '2023-02-25', 4000),
(3, 3, '2023-03-30', 10000),
(4, 4, '2023-05-05', 5500),
(5, 5, '2023-06-10', 12000),
(6, 6, '2023-07-15', 9000),
(7, 7, '2023-08-20', 6500),
(8, 8, '2023-09-25', 15000),
(9, 9, '2023-10-30', 8000),
(10, 10, '2023-11-05', 9500),
(11, 11, '2023-12-10', 7000),
(12, 12, '2024-01-15', 10500),
(13, 13, '2024-02-20', 8500),
(14, 14, '2024-03-25', 6000),
(15, 15, '2024-04-30', 13500),
(16, 16, '2024-05-05', 10000),
(17, 17, '2024-06-10', 7500),
(18, 18, '2024-07-15', 11000),
(19, 19, '2024-08-20', 5000),
(20, 20, '2024-09-25', 12500);

INSERT INTO ������_������ (ID_������_������, ID_������, ������_������, ���������_������, �����_�����������_������, ����_���������, ��������) VALUES
(1, 1, '� ���������', '������������ �������� "��������"', '������', NULL, '�������� ��� BMW'),
(2, 2, '��������', '������������ �������� "��������"', '�����-���������', '2023-02-28', '������� ��� �����������'),
(3, 3, '������� ������', '������������ �������� "��������"', '������������', NULL, '��������� �������'),
(4, 4, '� ���������', '������������ �������� "������-��������"', '�����������', NULL, '������������'),
(5, 5, '��������', '������������ �������� "������"', '���������', '2023-06-15', '������� ����������'),
(6, 6, '������� ��������', '������������ �������� "������-��������"', '�����������', NULL, '��������� �������'),
(7, 7, '� ���������', '������������ �������� "��������"', '������-��-����', NULL, '�������� � ������������'),
(8, 8, '������� ������', '������������ �������� "��������"', '������', NULL, '����� � ������ ���'),
(9, 9, '��������', '������������ �������� "������"', '������ ��������', '2023-10-30', '����� � ��������� �������'),
(10, 10, '� ���������', '������������ �������� "��������"', '���������', NULL, '��������� � �����������'),
(11, 11, '������� ������', '������������ �������� "������-��������"', '����������', NULL, '���� � ������'),
(12, 12, '��������', '������������ �������� "��������"', '�����', '2023-12-20', '������������� ��������'),
(13, 13, '� ���������', '������������ �������� "��������"', '�������', NULL, '���������� � �������'),
(14, 14, '������� ��������', '������������ �������� "������"', '���', NULL, '����� ��������� � �����������'),
(15, 15, '��������', '������������ �������� "��������"', '�����', '2024-04-30', '������� ����������'),
(16, 16, '������� ������', '������������ �������� "������-��������"', '������', NULL, '����������������'),
(17, 17, '� ���������', '������������ �������� "��������"', '����', NULL, '��������� � ������������'),
(18, 18, '��������', '������������ �������� "��������"', '�������', '2024-07-30', '��������� �������'),
(19, 19, '������� ������', '������������ �������� "������"', '�������', NULL, '����������� � �������'),
(20, 20, '��������', '������������ �������� "��������"', '�����', '2024-09-30', '��������� � �����������');

	-- ������� ������ � ������� ������������
INSERT INTO ������������ (�����_������������, ������_������������, �����, ���������, ������������)
VALUES ('user1', 'password1', 1, 0, 0),  -- ������ ������������ �������� ���������������
       ('user2', 'password2', 0, 1, 0),  -- ������ ������������ �������� �����������
       ('user3', 'password3', 0, 0, 1);  -- ������ ������������ �������� ������� �������������