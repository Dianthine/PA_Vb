-- Tabel Anggota
CREATE TABLE `Tbl_Anggota` (
    `id_anggota` VARCHAR(20) PRIMARY KEY,
    `nama_anggota` VARCHAR(100),
    `nim` VARCHAR(50),
    `jenis_kelamin` VARCHAR(10),
    `alamat` VARCHAR(255),
    `no_telp` VARCHAR(15)
);
-- Anggota Perpustakaan --
INSERT INTO tbl_anggota (id_anggota, nama_anggota, nim, jenis_kelamin, alamat, no_telp) VALUES
('A001','Ahmad Suryadi', '18020001', 'L', 'Jl. Merdeka No. 12, Jakarta', '081234567890'),
('A002','Budi Santoso', '18020002', 'L', 'Jl. Sudirman No. 45, Bandung', '081234567891'),
('A003','Citra Anggraini', '18020003', 'P', 'Jl. Diponegoro No. 67, Surabaya', '081234567892'),
('A004','Dewi Lestari', '18020004', 'P', 'Jl. Gatot Subroto No. 89, Malang', '081234567893'),
('A005','Eka Prasetya', '18020005', 'L', 'Jl. Ahmad Yani No. 11, Yogyakarta', '081234567894'),
('A006','Fajar Hidayat', '18020006', 'L', 'Jl. Mangga Dua No. 23, Medan', '081234567895'),
('A007','Gita Puspita', '18020007', 'P', 'Jl. Kebon Jeruk No. 34, Bekasi', '081234567896'),
('A008','Heri Gunawan', '18020008', 'L', 'Jl. Cikini No. 56, Depok', '081234567897'),
('A009','Indah Permatasari', '18020009', 'P', 'Jl. Kalimalang No. 78, Tangerang', '081234567898'),
('A010','Joko Sutrisno', '18020010', 'L', 'Jl. Pahlawan No. 90, Bogor', '081234567899'),
('A011','Kartika Sari', '18020011', 'P', 'Jl. Bambu Kuning No. 12, Solo', '081234567900'),
('A012','Lestari Putri', '18020012', 'P', 'Jl. Anggrek No. 34, Semarang', '081234567901'),
('A013','Made Suwardi', '18020013', 'L', 'Jl. Teuku Umar No. 56, Bali', '081234567902'),
('A014','Nia Ramadhani', '18020014', 'P', 'Jl. Mataram No. 78, Aceh', '081234567903'),
('A015','Oka Pratama', '18020015', 'L', 'Jl. Imam Bonjol No. 90, Bali', '081234567904'),
('A016','Putri Andini', '18020016', 'P', 'Jl. Gajah Mada No. 12, Pontianak', '081234567905'),
('A017','Rizki Kurniawan', '18020017', 'L', 'Jl. Rajawali No. 34, Palembang', '081234567906'),
('A018','Siti Nurhaliza', '18020018', 'P', 'Jl. Kenanga No. 56, Banjarmasin', '081234567907'),
('A019','Taufik Hidayat', '18020019', 'L', 'Jl. Melati No. 78, Makassar', '081234567908'),
('A020','Umi Kalsum', '18020020', 'P', 'Jl. Cemara No. 90, Lampung', '081234567909');

-- Tabel Buku
CREATE TABLE `Tbl_Buku` (
    `id_buku` VARCHAR(20) PRIMARY KEY,
    `judul` VARCHAR(255),
    `tahun_terbit` VARCHAR(4),
    `genre` VARCHAR(50),
    `penerbit` VARCHAR(100),
    `pengarang` VARCHAR(100),
    `stock` VARCHAR(10)
);
-- Insert untuk buku dengan genre pengetahuan
INSERT INTO Tbl_Buku (id_buku, judul, tahun_terbit, genre, penerbit, pengarang, stock) VALUES
('B001', 'Sapiens: A Brief History of Humankind', '2011', 'Pengetahuan', 'Harper', 'Yuval Noah Harari', '10'),
('B002', 'Guns, Germs, and Steel', '1997', 'Pengetahuan', 'W. W. Norton & Company', 'Jared Diamond', '8'),
('B003', 'The Gene: An Intimate History', '2016', 'Pengetahuan', 'Scribner', 'Siddhartha Mukherjee', '6'),
('B004', 'Cosmos', '1980', 'Pengetahuan', 'Ballantine Books', 'Carl Sagan', '12'),
('B005', 'A Brief History of Time', '1988', 'Pengetahuan', 'Bantam Books', 'Stephen Hawking', '7'),
('B006', 'Thinking, Fast and Slow', '2011', 'Pengetahuan', 'Farrar, Straus and Giroux', 'Daniel Kahneman', '9'),
('B007', 'Sapiens: A Graphic History', '2020', 'Pengetahuan', 'Harper Perennial', 'Yuval Noah Harari', '5'),
('B008', 'The Immortal Life of Henrietta Lacks', '2010', 'Pengetahuan', 'Crown Publishing Group', 'Rebecca Skloot', '11'),
('B009', 'Educated', '2018', 'Pengetahuan', 'Random House', 'Tara Westover', '8'),
('B010', 'Why We Sleep: Unlocking the Power of Sleep and Dreams', '2017', 'Pengetahuan', 'Simon & Schuster', 'Matthew Walker', '6')
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
('B040', 'World War Z', '2006', 'Horor', 'Crown Publishing Group', 'Max Brooks', '9');

-- Tabel Peminjaman
CREATE TABLE `Tbl_Peminjaman` (
    `id_transaksi` VARCHAR(20) PRIMARY KEY,
    `id_anggota` VARCHAR(20),
    `nama_anggota` VARCHAR(100),
    `judul` VARCHAR(255),
    `jumlah` VARCHAR(10),
    `keterangan` VARCHAR(255),
    `tgl_kembali` VARCHAR(10),
    `status` VARCHAR(50),
    FOREIGN KEY (`id_anggota`) REFERENCES `Tbl_Anggota` (`id_anggota`)
);
-- Peminjaman
INSERT INTO Tbl_Peminjaman (id_transaksi, id_anggota, nama_anggota, judul, jumlah, keterangan, tgl_kembali, status) VALUES 
('P001', '1', 'Ahmad Suryadi', 'Sapiens: A Brief History of Humankind', '2', 'Peminjaman pertama', '2024-06-25', 'Diproses'),
('P002', '10', 'Joko Sutrisno', 'Harry Potter and the Sorcerers Stone', '1', 'Peminjaman kedua', '2024-06-22', 'Sedang Dipinjam'),
('P003', '11', 'Kartika Sari', 'Neuromancer', '3', 'Peminjaman ketiga', '2024-06-28', 'Selesai'),
('P004', '12', 'Lestari Putri', 'The Shining', '2', 'Peminjaman keempat', '2024-06-24', 'Telat'),
('P005', '13', 'Made Suwardi', 'Dune', '1', 'Peminjaman kelima', '2024-06-26', 'Belum Diproses'),
('P006', '14', 'Nia Ramadhani', 'A Game of Thrones', '2', 'Peminjaman keenam', '2024-06-23', 'Sudah Dikembalikan'),
('P007', '15', 'Oka Pratama', 'Dracula', '1', 'Peminjaman ketujuh', '2024-06-27', 'Dibatalkan');

-- Perubahan pada Tbl_peminjaman
 -- Tambahkan kolom tgl_pinjam
ALTER TABLE Tbl_Peminjaman ADD COLUMN `tgl_pinjam` VARCHAR(10) AFTER `judul`;

-- Hapus kolom jumlah
ALTER TABLE Tbl_Peminjaman DROP COLUMN `jumlah`;

-- Perbarui nilai keterangan menjadi "Nihil" untuk semua baris
UPDATE Tbl_Peminjaman SET keterangan = 'Nihil';

-- Contoh untuk memperbarui kolom tgl_pinjam (tambahkan tgl_pinjam sesuai kebutuhan)
UPDATE Tbl_Peminjaman SET tgl_pinjam = '2024-06-18' WHERE id_transaksi = 'P001';
UPDATE Tbl_Peminjaman SET tgl_pinjam = '2024-06-15' WHERE id_transaksi = 'P002';
UPDATE Tbl_Peminjaman SET tgl_pinjam = '2024-06-18' WHERE id_transaksi = 'P003';
UPDATE Tbl_Peminjaman SET tgl_pinjam = '2024-06-14' WHERE id_transaksi = 'P004';
UPDATE Tbl_Peminjaman SET tgl_pinjam = '2024-06-16' WHERE id_transaksi = 'P005';
UPDATE Tbl_Peminjaman SET tgl_pinjam = '2024-06-13' WHERE id_transaksi = 'P006';
UPDATE Tbl_Peminjaman SET tgl_pinjam = '2024-06-17' WHERE id_transaksi = 'P007';

-- Perubahan pada tbl_anggota
-- Tambahkan kolom email di atas no_telp
ALTER TABLE Tbl_Anggota ADD COLUMN `email` VARCHAR(100) AFTER `jenis_kelamin`;

-- Hapus kolom alamat
ALTER TABLE Tbl_Anggota DROP COLUMN `alamat`;

-- Contoh data dengan tambahan email
UPDATE Tbl_Anggota
SET email = CASE
    WHEN id_anggota = 'A001' THEN 'ahmad@email.com'
    WHEN id_anggota = 'A002' THEN 'budi@email.com'
    WHEN id_anggota = 'A003' THEN 'citra@email.com'
    WHEN id_anggota = 'A004' THEN 'dewi@email.com'
    WHEN id_anggota = 'A005' THEN 'eka@email.com'
    WHEN id_anggota = 'A006' THEN 'fajar@email.com'
    WHEN id_anggota = 'A007' THEN 'gita@email.com'
    WHEN id_anggota = 'A008' THEN 'heri@email.com'
    WHEN id_anggota = 'A009' THEN 'indah@email.com'
    WHEN id_anggota = 'A010' THEN 'joko@email.com'
    WHEN id_anggota = 'A011' THEN 'kartika@email.com'
    WHEN id_anggota = 'A012' THEN 'lestari@email.com'
    WHEN id_anggota = 'A013' THEN 'made@email.com'
    WHEN id_anggota = 'A014' THEN 'nia@email.com'
    WHEN id_anggota = 'A015' THEN 'oka@email.com'
    WHEN id_anggota = 'A016' THEN 'putri@email.com'
    WHEN id_anggota = 'A017' THEN 'rizki@email.com'
    WHEN id_anggota = 'A018' THEN 'siti@email.com'
    WHEN id_anggota = 'A019' THEN 'taufik@email.com'
    WHEN id_anggota = 'A020' THEN 'umi@email.com'
    ELSE NULL
END;
