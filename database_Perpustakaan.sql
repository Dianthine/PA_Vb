-- Tabel Admin
CREATE TABLE `Tbl_Admin` (
    `Username` VARCHAR(50) PRIMARY KEY,
    `Password` VARCHAR(50),
    `Nama` VARCHAR(100)
);

-- Tabel Anggota
CREATE TABLE `Tbl_Anggota` (
    `id_anggota` VARCHAR(20) PRIMARY KEY,
    `nama_anggota` VARCHAR(100),
    `nim` VARCHAR(50),
    `tgl_lahir` VARCHAR(10),
    `jenis_kelamin` VARCHAR(10),
    `alamat` VARCHAR(255),
    `no_telp` VARCHAR(15)
);

-- Tabel Buku
CREATE TABLE `Tbl_Buku` (
    `id_buku` VARCHAR(20) PRIMARY KEY,
    `isbn` VARCHAR(20),
    `judul` VARCHAR(255),
    `tahun_terbit` VARCHAR(4),
    `penerbit` VARCHAR(100),
    `pengarang` VARCHAR(100),
    `stock` VARCHAR(10)
);

-- Tabel Peminjaman
CREATE TABLE `Tbl_Peminjaman` (
    `id_transaksi` VARCHAR(20) PRIMARY KEY,
    `id_anggota` VARCHAR(20),
    `nama_anggota` VARCHAR(100),
    `nama_buku` VARCHAR(255),
    `jumlah` VARCHAR(10),
    `keterangan` VARCHAR(255),
    `tgl_kembali` VARCHAR(10),
    `status` VARCHAR(50),
    FOREIGN KEY (`id_anggota`) REFERENCES `Tbl_Anggota` (`id_anggota`)
);