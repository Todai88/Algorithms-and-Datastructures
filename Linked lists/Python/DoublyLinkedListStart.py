from LinkedList import Doubly

if __name__ == "__main__":
    linked_list = Doubly.Doubly()
    linked_list.add_first("hello")
    print(linked_list._head._value)