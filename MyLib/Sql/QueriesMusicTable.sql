Select count(song.name)
From albums as alb
JOIN songs as song 
on song.album_id = alb.id
where alb.name = "Album A1"