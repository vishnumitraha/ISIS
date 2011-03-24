﻿Feature: Create A Course
	In order to manage the course schedule
	As a scheduler
	I want to set up a new course

@domain
Scenario: Create a credit course
	When I create an ACAD course BIOL 1301 Introductory Biology
	Then the course is created
	And the course rubric is BIOL
	And the course number is 1301
	And the course title is Introductory Biology
	And the course long title is Introductory Biology
	And the course is active
	And the ACAD course type is added
	And the current course type is ACAD
	And it should do nothing else

@domain
Scenario: Create a CE course
	When I create a Workforce Funded course AGEQ 1091 Routine Management of Equine Health
	Then the course is created
	And the course rubric is AGEQ
	And the course number is 1091
	And the course title is Routine Management of Equine H
	And the course long title is Routine Management of Equine Health
	And the course is active
	And the CWECM course type is added
	And the current course type is CWECM
	And the credit type is Workforce Funded
	And the CEUs are 0
	And it should do nothing else