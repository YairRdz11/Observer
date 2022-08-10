# Observer Pattern

Definition:
The Observer Pattern defines a one to many dependency between objects so that one object changes state, all of its dependents are notified and updated automatically.

Explanation:

One to many dependency is between Subject(One) and Observer(Many).
There is dependency as Observers themselves don’t have access to data. They are dependent on Subject to provide them data.

Scenario:

Suppose we are building a cricket app that notifies viewers about the information such as current score, run rate etc. Suppose we have made two display elements CurrentScoreDisplay and AverageScoreDisplay. CricketData has all the data (runs, bowls etc.) and whenever data changes the display elements are notified with new data and they display the latest data accordingly.


This example was found in <a href="https://www.geeksforgeeks.org/observer-pattern-set-1-introduction/" target="_blank">Geekforgeeks</a> please click for more information
