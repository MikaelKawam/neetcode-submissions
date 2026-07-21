class PrefixTree:
    def __init__(self):
        self.values = []

    def insert(self, word: str) -> None:
        self.values.append(word)

    def search(self, word: str) -> bool:
        for s in self.values:
            if s == word:
                return True
        return False

    def startsWith(self, prefix: str) -> bool:
        for s in self.values:
            if s[0:len(prefix)] == prefix:
                return True
        return False
        
        