class Song:
    def __init__(self, song_name, song_length: float, single: bool):
        self.song_name = song_name
        self.song_length = song_length
        self.single = single

    def get_info(self):
        return f'{self.song_name} - {self.song_length}'
