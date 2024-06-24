-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Jun 2024 pada 07.37
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_perpustakaan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_anggota`
--

CREATE TABLE `tbl_anggota` (
  `id_anggota` varchar(20) NOT NULL,
  `nama_anggota` varchar(100) DEFAULT NULL,
  `nim` varchar(50) DEFAULT NULL,
  `jenis_kelamin` varchar(10) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `no_telp` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_anggota`
--

INSERT INTO `tbl_anggota` (`id_anggota`, `nama_anggota`, `nim`, `jenis_kelamin`, `email`, `no_telp`) VALUES
('A001', 'Ahmad Suryadi', '18020001', 'laki-laki', 'ahmad@email.com', '081234567890'),
('A002', 'Budi Santoso', '18020002', 'laki-laki', 'budi@email.com', '081234567891'),
('A003', 'Citra Anggraini', '18020003', 'perempuan', 'citra@email.com', '081234567892'),
('A004', 'Dewi Lestari', '18020004', 'perempuan', 'dewi@email.com', '081234567893'),
('A005', 'Eka Prasetya', '18020005', 'laki-laki', 'eka@email.com', '081234567894'),
('A006', 'Fajar Hidayat', '18020006', 'laki-laki', 'fajar@email.com', '081234567895'),
('A007', 'Gita Puspita', '18020007', 'perempuan', 'gita@email.com', '081234567896'),
('A008', 'Heri Gunawan', '18020008', 'laki-laki', 'heri@email.com', '081234567897'),
('A009', 'Indah Permatasari', '18020009', 'perempuan', 'indah@email.com', '081234567898'),
('A010', 'Joko Sutrisno', '18020010', 'laki-laki', 'joko@email.com', '081234567899'),
('A011', 'Kartika Sari', '18020011', 'perempuan', 'kartika@email.com', '081234567900'),
('A012', 'Lestari Putri', '18020012', 'perempuan', 'lestari@email.com', '081234567901'),
('A013', 'Made Suwardi', '18020013', 'laki-laki', 'made@email.com', '081234567902'),
('A014', 'Nia Ramadhani', '18020014', 'perempuan', 'nia@email.com', '081234567903'),
('A015', 'Oka Pratama', '18020015', 'laki-laki', 'oka@email.com', '081234567904'),
('A016', 'Putri Andini', '18020016', 'perempuan', 'putri@email.com', '081234567905'),
('A017', 'Rizki Kurniawan', '18020017', 'laki-laki', 'rizki@email.com', '081234567906'),
('A018', 'Siti Nurhaliza', '18020018', 'perempuan', 'siti@email.com', '081234567907'),
('A019', 'Taufik Hidayat', '18020019', 'laki-laki', 'taufik@email.com', '081234567908'),
('A020', 'Umi Kalsum', '18020020', 'perempuan', 'umi@email.com', '081234567909'),
('A021', 'atthar', '1554', 'laki-laki', 'fathan@gmail.com', '082198765432');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_buku`
--

CREATE TABLE `tbl_buku` (
  `id_buku` varchar(20) NOT NULL,
  `judul` varchar(255) DEFAULT NULL,
  `tahun_terbit` varchar(4) DEFAULT NULL,
  `genre` varchar(50) DEFAULT NULL,
  `penerbit` varchar(100) DEFAULT NULL,
  `pengarang` varchar(100) DEFAULT NULL,
  `stock` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_buku`
--

INSERT INTO `tbl_buku` (`id_buku`, `judul`, `tahun_terbit`, `genre`, `penerbit`, `pengarang`, `stock`) VALUES
('B001', 'Sapiens: A Brief History of Humankind', '2011', 'Pengetahuan', 'Harper', 'Yuval Noah Harari', '10'),
('B002', 'Guns, Germs, and Steel', '1997', 'Pengetahuan', 'W. W. Norton & Company', 'Jared Diamond', '8'),
('B003', 'The Gene: An Intimate History', '2016', 'Pengetahuan', 'Scribner', 'Siddhartha Mukherjee', '6'),
('B004', 'Cosmos', '1980', 'Pengetahuan', 'Ballantine Books', 'Carl Sagan', '12'),
('B005', 'A Brief History of Time', '1988', 'Pengetahuan', 'Bantam Books', 'Stephen Hawking', '7'),
('B006', 'Thinking, Fast and Slow', '2011', 'Pengetahuan', 'Farrar, Straus and Giroux', 'Daniel Kahneman', '9'),
('B007', 'Sapiens: A Graphic History', '2020', 'Pengetahuan', 'Harper Perennial', 'Yuval Noah Harari', '5'),
('B008', 'The Immortal Life of Henrietta Lacks', '2010', 'Pengetahuan', 'Crown Publishing Group', 'Rebecca Skloot', '11'),
('B009', 'Educated', '2018', 'Pengetahuan', 'Random House', 'Tara Westover', '8'),
('B010', 'Why We Sleep: Unlocking the Power of Sleep and Dreams', '2017', 'Pengetahuan', 'Simon & Schuster', 'Matthew Walker', '6'),
('B011', 'Dune', '1965', 'Fiksi Ilmiah', 'Chilton Books', 'Frank Herbert', '15'),
('B012', 'Neuromancer', '1984', 'Fiksi Ilmiah', 'Ace Books', 'William Gibson', '10'),
('B013', 'Foundation', '1951', 'Fiksi Ilmiah', 'Gnome Press', 'Isaac Asimov', '12'),
('B014', 'The Left Hand of Darkness', '1969', 'Fiksi Ilmiah', 'Ace Books', 'Ursula K. Le Guin', '8'),
('B015', 'Snow Crash', '1992', 'Fiksi Ilmiah', 'Bantam Spectra', 'Neal Stephenson', '9'),
('B016', 'Hyperion', '1989', 'Fiksi Ilmiah', 'Doubleday', 'Dan Simmons', '11'),
('B017', '1984', '1949', 'Fiksi Ilmiah', 'Secker & Warburg', 'George Orwell', '7'),
('B018', 'Brave New World', '1932', 'Fiksi Ilmiah', 'Chatto & Windus', 'Aldous Huxley', '10'),
('B019', 'The Martian', '2011', 'Fiksi Ilmiah', 'Crown Publishing Group', 'Andy Weir', '13'),
('B020', 'Ender\'s Game', '1985', 'Fiksi Ilmiah', 'Tor Books', 'Orson Scott Card', '9'),
('B021', 'The Hobbit', '1937', 'Fantasi', 'George Allen & Unwin', 'J.R.R. Tolkien', '12'),
('B022', 'Harry Potter and the Sorcerer\'s Stone', '1997', 'Fantasi', 'Bloomsbury Publishing', 'J.K. Rowling', '15'),
('B023', 'A Game of Thrones', '1996', 'Fantasi', 'Bantam Spectra', 'George R.R. Martin', '10'),
('B024', 'Mistborn: The Final Empire', '2006', 'Fantasi', 'Tor Books', 'Brandon Sanderson', '9'),
('B025', 'The Name of the Wind', '2007', 'Fantasi', 'DAW Books', 'Patrick Rothfuss', '8'),
('B026', 'The Lies of Locke Lamora', '2006', 'Fantasi', 'Bantam Spectra', 'Scott Lynch', '11'),
('B027', 'The Way of Kings', '2010', 'Fantasi', 'Tor Books', 'Brandon Sanderson', '13'),
('B028', 'The Fellowship of the Ring', '1954', 'Fantasi', 'George Allen & Unwin', 'J.R.R. Tolkien', '10'),
('B029', 'Jonathan Strange & Mr Norrell', '2004', 'Fantasi', 'Bloomsbury Publishing', 'Susanna Clarke', '7'),
('B030', 'The Magicians', '2009', 'Fantasi', 'Viking Press', 'Lev Grossman', '9'),
('B031', 'Dracula', '1897', 'Horor', 'Archibald Constable and Company', 'Bram Stoker', '10'),
('B032', 'Frankenstein', '1818', 'Horor', 'Lackington, Hughes, Harding, Mavor, & Jones', 'Mary Shelley', '8'),
('B033', 'The Shining', '1977', 'Horor', 'Doubleday', 'Stephen King', '12'),
('B034', 'Pet Sematary', '1983', 'Horor', 'Doubleday', 'Stephen King', '9'),
('B035', 'IT', '1986', 'Horor', 'Viking', 'Stephen King', '11'),
('B036', 'House of Leaves', '2000', 'Horor', 'Pantheon Books', 'Mark Z. Danielewski', '7'),
('B037', 'The Haunting of Hill House', '1959', 'Horor', 'Viking Press', 'Shirley Jackson', '10'),
('B038', 'Bird Box', '2014', 'Horor', 'Ecco', 'Josh Malerman', '8'),
('B039', 'The Exorcist', '1971', 'Horor', 'Harper & Row', 'William Peter Blatty', '6'),
('B040', 'World War Z', '2006', 'Horor', 'Crown Publishing Group', 'Max Brooks', '9'),
('B041', 'Qiwi', '2024', 'Buku Anak - Anak', 'attahr', 'asfri', '60'),
('B042', 'Peri Kecil', '2024', 'Buku Anak - Anak', 'kaki', 'Asfari', '20');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_peminjaman`
--

CREATE TABLE `tbl_peminjaman` (
  `id_transaksi` varchar(20) NOT NULL,
  `id_anggota` varchar(20) DEFAULT NULL,
  `id_buku` varchar(20) DEFAULT NULL,
  `nama_anggota` varchar(100) DEFAULT NULL,
  `judul` varchar(255) DEFAULT NULL,
  `tgl_pinjam` varchar(10) DEFAULT NULL,
  `tgl_kembali` varchar(10) DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_peminjaman`
--

INSERT INTO `tbl_peminjaman` (`id_transaksi`, `id_anggota`, `id_buku`, `nama_anggota`, `judul`, `tgl_pinjam`, `tgl_kembali`, `keterangan`, `status`) VALUES
('P001', 'A001', 'B001', 'Ahmad Suryadi', 'Sapiens: A Brief History of Humankind', '2024-06-20', '2024-06-27', 'nihil', 'Dipinjam'),
('P002', 'A002', 'B002', 'Budi Santoso', 'Guns, Germs, and Steel', '2024-06-20', '2024-06-27', 'nihil', 'Dipinjam'),
('P003', 'A003', 'B003', 'Citra Anggraini', 'The Gene: An Intimate History', '2024-06-20', '2024-06-27', 'nihil', 'Dipinjam'),
('P004', 'A004', 'B004', 'Dewi Lestari', 'Cosmos', '2024-06-20', '2024-06-27', 'nihil', 'Dipinjam'),
('P005', 'A005', 'B005', 'Eka Prasetya', 'A Brief History of Time', '2024-06-20', '2024-06-27', 'nihil', 'Dipinjam'),
('P006', 'A006', 'B006', 'Fajar Hidayat', 'Thinking, Fast and Slow', '2024-06-20', '2024-06-27', 'nihil', 'Dipinjam'),
('P007', 'A007', 'B007', 'Gita Puspita', 'Sapiens: A Graphic History', '2024-06-20', '2024-06-27', 'nihil', 'Dipinjam'),
('P008', 'A020', 'B027', 'Umi Kalsum', 'The Way of Kings', '2024-06-20', '2024-06-27', 'nihil', 'Dipinjam'),
('P009', 'A015', 'B010', 'Oka Pratama', 'Why We Sleep: Unlocking the Power of Sleep and Dreams', '2024-06-20', '2024-06-27', 'nihil', 'Kembali'),
('P010', 'A021', 'B042', 'atthar', 'Peri Kecil', '2024-06-24', '2024-07-01', 'Mulus', 'Kembali'),
('P011', 'A019', 'B013', 'Taufik Hidayat', 'Foundation', '2024-06-24', '2024-07-01', 'nihil', 'Pinjam'),
('P012', 'A019', 'B014', 'Taufik Hidayat', 'The Left Hand of Darkness', '2024-06-24', '2024-07-01', 'Nihil', 'Pinjam');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_anggota`
--
ALTER TABLE `tbl_anggota`
  ADD PRIMARY KEY (`id_anggota`);

--
-- Indeks untuk tabel `tbl_buku`
--
ALTER TABLE `tbl_buku`
  ADD PRIMARY KEY (`id_buku`);

--
-- Indeks untuk tabel `tbl_peminjaman`
--
ALTER TABLE `tbl_peminjaman`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `fk_peminjaman_buku` (`id_buku`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_peminjaman`
--
ALTER TABLE `tbl_peminjaman`
  ADD CONSTRAINT `fk_peminjaman_buku` FOREIGN KEY (`id_buku`) REFERENCES `tbl_buku` (`id_buku`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
