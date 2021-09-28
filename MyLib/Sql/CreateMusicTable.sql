create table artists (
    id integer primary key AUTOINCREMENT,
    name varchar(20)
);

create table albums (
    id integer primary key AUTOINCREMENT,
    name varchar(20),
    artist_id integer,
    FOREIGN KEY (artist_id) REFERENCES artists(id)
);

create table songs (
    id integer primary key AUTOINCREMENT,
    name varchar(20),
    genre varchar(20),
    length integer,
    album_id integer,
    FOREIGN KEY (album_id) references albums(id)
);

create table albumSongs (
    id integer primary key AUTOINCREMENT,
    song_id integer,
    album_id integer,
    FOREIGN key (song_id) references songs(id),
    FOREIGN key (album_id) references albums(id)
);