insert into artists (name) values ("Artist A");
insert into artists (name) values ("Artist B");
insert into artists (name) values ("Artist C");


insert into albums (name, artist_id) values ("Album A1", 1);
insert into albums (name, artist_id) values ("Album A2", 1);
insert into albums (name, artist_id) values ("Album B1", 2);
insert into albums (name, artist_id) values ("Album B2", 2);
insert into albums (name, artist_id) values ("Album C1", 3);
insert into albums (name, artist_id) values ("Album C2", 3);

insert into albums (name, artist_id) values ("Album Z", 1);


insert into songs (name, genre, length, album_id) values ("Song A1_1", "Blues", 130, 1);
insert into songs (name, genre, length, album_id) values ("Song A1_2", "Alternative", 200, 1);
insert into songs (name, genre, length, album_id) values ("Song A2_1", "Rock", 190, 2);
insert into songs (name, genre, length, album_id) values ("Song A2_2", "Country", 140, 2);
insert into songs (name, genre, length, album_id) values ("Song B1_1", "Pop", 150, 3);
insert into songs (name, genre, length, album_id) values ("Song B1_2", "Classical", 220, 3);
insert into songs (name, genre, length, album_id) values ("Song B2_1", "Urban", 210, 4);
insert into songs (name, genre, length, album_id) values ("Song B2_2", "R&B", 190, 4);
insert into songs (name, genre, length, album_id) values ("Song C1_1", "Indie", 180, 5);
insert into songs (name, genre, length, album_id) values ("Song C1_2", "Hip-hop", 170, 5);
insert into songs (name, genre, length, album_id) values ("Song C2_1", "Metal", 200, 6);
insert into songs (name, genre, length, album_id) values ("Song C2_2", "Jazz", 210, 6);

insert into songs (name, album_id) values ("Song A1_1", 7);


insert into albumSongs (song_id, album_id) values (1, 1);
insert into albumSongs (song_id, album_id) values (2, 1);
insert into albumSongs (song_id, album_id) values (3, 2);
insert into albumSongs (song_id, album_id) values (4, 2);
insert into albumSongs (song_id, album_id) values (5, 3);
insert into albumSongs (song_id, album_id) values (6, 3);
insert into albumSongs (song_id, album_id) values (7, 4);
insert into albumSongs (song_id, album_id) values (8, 4);
insert into albumSongs (song_id, album_id) values (9, 5);
insert into albumSongs (song_id, album_id) values (10, 5);
insert into albumSongs (song_id, album_id) values (11, 6);
insert into albumSongs (song_id, album_id) values (12, 6);

insert into albumSongs (song_id, album_id) values (1, 7);