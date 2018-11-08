from .LinkedNodes import DoublyLinkedNode

class Doubly:
    def __init__(self):
        self._head = None
        self._tail = None
        self._count = 0

    @property
    def head(self):
        return self._head
    
    @head.setter
    def head(self, new_node):
        self._head = new_node

    @property
    def tail(self):
        return self._tail
    
    @tail.setter
    def tail(self, new_node):
        self._tail = new_node

    @property
    def count(self):
        return self._count
    
    @count.setter
    def count(self, new_count):
        self._count = new_count

    def isEmpty(self):
        return self._head == None
    
    def add_first(self, value):
        new_node = DoublyLinkedNode.DoublyLinkedNode(value)
        new_node.next = self._head
        self._head = new_node
        if self._count == 0:
            self._tail = self._head
        self._count += 1
    
    def add_last(self, value):
        new_node = DoublyLinkedNode.DoublyLinkedNode(value)
        if self._count == 0:
            self._head = new_node
        else:
            self._tail._next = new_node
        self._tail = new_node
        
        self._count += 1
    
    def find(self, value):
        found = False
        current = self._head
        if self._count == 0:
            return found
        while current != None and not found:
            if current._next._value == value:
                found = True
            else:
                current = current._next
        return found
    
    def remove(self, value):
        current = self._head
        previous = None
        found = False
        while current != None:
            if current._value == value:
                if previous == None:
                    self._head = current._next
                else:
                    previous._next = current._next
            else:
                previous = current
                current = current._next 

    def remove_first(self):
        if (self._count != 0):
            self._head = self._head._next
            self._count -= 1
            if self._count == 0:
                self._tail = None
    
    def remove_last(self):
        if self._count != 0:
            if self._count == 1:
                self._head = None
                self._tail = None
            else:
                current = self._head
                while current._next != self._tail:
                    current = current._next
                current._next = None
                self._tail = current
            self._count -= 1

