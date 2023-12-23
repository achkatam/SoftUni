from project.album import Album
from project.song import Song


class Band:
    def __init__(self, band_name):
        self.name = band_name
        self.albums = []

    def add_album(self, album: Album):
        if album in self.albums:
            return f'Band {self.name} already has {album.album_name} in their library.'

        self.albums.append(album)
        return f'Band {self.name} has added their newest album {album.album_name}.'

    def remove_album(self, album_name):
        for al in self.albums:
            if al.album_name == album_name:
                if al.published:
                    return f'Album has been published. It cannot be removed.'
                else:
                    self.albums.remove(al)
                    return f'Album {album_name} has been removed.'

        return f'Album {album_name} is not found.'

    def details(self):
        string_builder = f'Band {self.name}'

        for album in self.albums:
            string_builder += f'\n{album.details()}'

        return string_builder


band = Band("Death")
message = f"{band.name} - {len(band.albums)}"
print(message)
