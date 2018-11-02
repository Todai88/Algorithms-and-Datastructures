class DoublyLinkedNode():
    
    def __init__(self, value):
        self._value = value
        self._next = None
        self._previous = None

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

    @property
    def previous(self):
        return self._previous
    
    @previous.setter
    def previous(self, newNode):
        self._previous = newNode

