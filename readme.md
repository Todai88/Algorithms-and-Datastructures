This repository serves as a refresher for some algorithms and datastructures.

They will primarily be written in **C#**, but other languages may be added.

# Python refresher

### Classes:
No need for getters or setters, but use `@properties` if possible, it makes reading code more verbose.
Local variables in the class-scope should be prefixed by an underscore (self._value) as there might be
strange clashes with recursion limit exceptions (SO) being thrown.

Example:

```
class Test():

    def __init__(self, value):
        self.value = value
    
    @property 
    def value():
        return self.value # This will throw an error

    @value.setter
    def setter(self, value):
        self.value = value # This will throw an error
```

CorrectioN:

```
class Test():

    def __init__(self, value):
        self._value = value
    
    @property 
    def value():
        return self._value # OK!

    @value.setter
    def setter(self, value):
        self._value = value # OK
```