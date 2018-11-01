class DoublyLinkedNode():
    
    def __init__(self, value):
        self._value = value
        self._next = None
    
    @property
    def value(self):
        return self._value
    
    @value.setter
    def value(self, newValue):
        self._value = newValue
    
    @property
    def next(self):
        return self._next
    
    @next.setter
    def next(self, newNode):
        self._next = newNode

if __name__ == "__main__":
    n = DoublyLinkedNode(93)
    print(n._value)