MergeWords (string word1, string word2)
TC01 - Should return chaoslaa if receive casa and hola
  I1: casa, I2: hola, O: chaoslaa

TC02 - Should throw argument exception if receive casa and ola
  I1: casa, I2: ola, O: ArgumentException

TC03 - Should throw argument exception if receive gato and palabra
  I1: gato, I2: palabra, O: ArgumentException
  
TC04 - Should throw argument exception if receive null and palabra
  I1: null, I2: palabra, O: ArgumentException

TC05 - Should throw argument exception if receive palabra and null
  I1: palabra, I2: null, O: ArgumentException

TC06 - Should throw argument exception if receive gato and 1234

SplitWords
