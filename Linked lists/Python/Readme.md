# Python refresher

### Importing
The Python interpreter searches in for modules following this sort of pattern:

```
1. modules in the Python Standard Library (e.g. math, os)
2. modules or packages in a directory specified by sys.path:
    1. If the Python interpreter is run interactively:
        * sys.path[0] is the empty string ''. This tells Python to search the current working directory from which you launched the interpreter, i.e. the output of pwd on Unix systems.
    If we run a script with python <script>.py:
        * sys.path[0] is the path to <script>.py
    2. directories in the PYTHONPATH environment variable
    3. default sys.path locations
```
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

Correction:

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