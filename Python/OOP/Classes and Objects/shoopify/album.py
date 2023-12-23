from project.song import Song


class Album:
    def __init__(self, album_name) -> None:
        self.album_name = album_name
        self.published = False
        self.songs = []

    def add_song(self, song: Song):
        if song.single:
            return f"Cannot add {song.song_name}. It's a single"
        elif self.published:
            return f"Cannot add songs. Album is published."
        elif song in self.songs:
            return f"Song is already in the album."
        else:
            self.songs.append(song)
            return f"Song {song.song_name} has been added to the album {self.album_name}."

    def remove_song(self, song_name):
        if self.published:
            return f"Cannot remove songs. Album is published."
        else:
            for idx, value in enumerate(self.songs):
                if value.song_name == song_name:
                    del self.songs[idx]
                    return f"Removed song {song_name} from album {self.album_name}."
            return "Song is not in the album."

    def publish(self):
        if self.published:
            return f"Album {self.album_name} is already published."
        self.published = True
        return f"Album {self.album_name} has been published."

    def details(self):
        string_builder = f"Album {self.album_name}\n"

        for song in self.songs:
            string_builder += f'== {song.get_info()}\n'

        return string_builder


album = Album("The Sound of Perseverance")
song = Song("Scavenger of Human Sorrow", 6.56, False)
print(album.add_song(song))
message = album.add_song(song)
print(message)
album = Album("The Sound of Perseverance")
song = Song("Scavenger of Human Sorrow", 6.56, True)
message = album.add_song(song)
print(message)
album = Album("The Sound of Perseverance")
song = Song("Scavenger of Human Sorrow", 6.56, False)
album.publish()
message = album.add_song(song)
print(message)
album = Album("The Sound of Perseverance")
song = Song("Scavenger of Human Sorrow", 6.56, False)
print(album.add_song(song))
message = album.remove_song("Scavenger of Human Sorrow")
print(message)
album = Album("The Sound of Perseverance")
song = Song("Scavenger of Human Sorrow", 6.56, False)
message = album.remove_song("Scavenger of Human Sorrow")
print(message)
album = Album("The Sound of Perseverance")
song = Song("Scavenger of Human Sorrow", 6.56, False)
print(album.add_song(song))
print(album.publish())
message = album.remove_song("Scavenger of Human Sorrow")
print(message)
album = Album("The Sound of Perseverance")
message = album.publish()
print(message)
print(album.published)
album = Album("The Sound of Perseverance")
message = album.publish()
print(message)
album = Album("The Sound of Perseverance")
song = Song("Scavenger of Human Sorrow", 6.56, False)
print(album.add_song(song))
message = album.details().strip()
print(message)
