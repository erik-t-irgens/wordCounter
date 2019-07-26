# _Number Count_

#### _Takes user input (sentence and word), and tells user how many times their word occurs within their sentence._

#### By _**Erik Irgens**_

## Description

_The user may input, when prompted, a WORD as well as a SENTENCE. The user is then prompted whether or not they'd like to see how many times their WORD occurs within their SENTENCE. If they submit YES, then they will be given the number, as well as a repeat of their input so they can check the validity of the claim. _


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program Gathers User Input** | User input: "Word, Sentence" | Input is recorded |
| **Program splits sentence into words**| User input: "sentence" | Input is changed from string to array containing lowercase individual words. |
| **Program counts the times WORD appears in SENTENCE**| WORD is compared to SENTENCE array\[i] | Output: Number of times WORD appears in SENTENCE (integer) |


## Setup/Installation Requirements

* _Clone down the repository from https://github.com/erik-t-irgens/wordCounter . _
* _If you'd like to run tests, navigate (in console) to the WordCounter.Tests directory and execute "dotnet resolve", then run "dotnet test" to see that the tests have passed._
* _To run the program proper, navigate (in console) to WordCounter directory, and run "dotnet run"._

## Known Bugs

_No known bugs_

## Support and contact details

_Contacts me at erik.t.irgens@gmail.com if there are any questions or concerns_

## Technologies Used

_This uses C#, .NET, and MSTest._

### License

*Copyright distribution on GPL*

Copyright (c) 2019 **_Erik Irgens_**
