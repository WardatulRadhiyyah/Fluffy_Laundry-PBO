CREATE TABLE [dbo].[Pelanggan] (
    [Id]                  INT           NOT NULL,
    [Nama]                NVARCHAR (50) NOT NULL,
    [No_Hp]               NVARCHAR (20) NOT NULL,
    [Berat_Cucian]        INT           NOT NULL,
    [Jenis_Paket]         NVARCHAR (10) NOT NULL,
    [Harga_Paket]         FLOAT (53)    NOT NULL,
    [Harga_Total]         FLOAT (53)    NOT NULL,
    [Tanggal_Pemsanan]    DATE          NOT NULL,
    [Tanggal_Pengambilan] DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

