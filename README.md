# Journey Hero Mono Repository

this repository contains Journey Hero backend solutions. we have a **[Common](Common)** Folder that contains common projects and 
each project in every layer could add reference to corresponding common project. 

each directory is for a particular project and should contain these sub-folders: 
  - docs
  - src
  - tests

**_docs_** contains documentations for project, including technical and business documentations.

**_src_** contains source codes but just source code! no tests included in this directory.
src contains sub-directories for each project, e.g. core, infrastructure, presentation

**_tests_** here we create write our tests, including unit, integration, end-to-end and so on. sub-directories and
structure should be **same as** src directory. 
