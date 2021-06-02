# VB-LAB code

This repository is used to store and view all code taught in VB-LAB class, for anyone to review or revisit what was taught.

I update this repo. the moment LAB session ends.

## Table of Contents:

| Form   | Function |
| ------ | -------- |
| Form 1 | Single input __basic calculator__ |
| Form 2 | __Two-variable Calculator__ with *Error-Provider control* |
| Form 3<sup>\[[1](#footnote1)\]</sup> | Full-fledged __9-button Calculator__ application |
| Form 4<sup>[[2](#footnote2)\]</sup> | *Custom Functionality* for Form3 |
| Form 5 | __List-box control__ demonstration application |
| Form 6 | __Progress bar__ & __Timer control__ |
| Form 7<sup>[[3](#footnote3)\]</sup> | Custom __Notepad__ application with RTF files support |
| Form 7a| __Find tool__ for MyNotepad application |
| Form 8 & 9 | Database access application |
| Form 9a | DataGridView control |
| Form 01<sup>[[4](#footnote4)\]</sup> | MDI container form |

<a name="footnote1">1</a>: The code in Form3.vb is heavily modified from what was taught in LAB. The original code could be found in [Form3#1.vb](./WindowsApplication1/Form3%231.vb) file.  
<a name="footnote2">2</a>: I created this form to add some additional functionality in my Calculator application (Form3), and is thus unrelated to what was taught in LAB.  
<a name="footnote3">3</a>: Code isn't complete yet, some functions are broken.  
<a name="footnote4">4</a>: Due to how VS sorts filenames, instead of Form 10, it is Form 01 so that Forms after this stay in order.


## Instructions to download this repo:

### For people unfamiliar with Git
* In __desktop__ browser, open repository's [root page](http://github.com/kushaagr/VB-LAB)
* Make sure you are on the main branch ie. the dropdown
  on top left shows "main" or "master"
* Click on the green button on top right named "Code"
* __Download as zip__ 

### Method two
* [Download Git](https://git-scm.com/download/Win) (Windows) then Install Git
* Open Git Bash
* Copy this command:
	```bash
	cd $HOME/downloads && git clone https://github.com/kushaagr/VB-LAB.git && explorer ".\VB-LAB"
	```
* *Right click* and paste (keyboard shortcut `SHIFT` + `INS`) this command. __Hit Enter__.
* A folder named VB-LAB should appear in your __Downloads__ folder.


## Contributing

* *Clone* the repo
* Before making any new edits in the repo, *create a **new** branch* 
* __Checkout__ new branch
* Edit and commit to *that* branch
* Before making a pull-request, make sure your local clone of this 
  repo. is up-to-date by issuing `git pull` in the __main__ branch
* *Issue* `git push` on __new branch__ and *open* pull request
