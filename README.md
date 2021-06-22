# Anagram-Kata
An anagram Kata technical test.

This test is to determine if two words are anagrams of each other. 

Currently a stub is used to provide data to the application - though a query project is in place to be able to retrieve this info from a database. Placeholder stored procedures have been used for this example.

The stub is only used in debug / test builds and is replaced in production builds with the database layer. This is acheived within the dependency injection in the program class.

Logging has been implemneted with Nlog.

Unit tests are written using Fluent Assertions and Xunit.