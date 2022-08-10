//Create objects for testing (Concret Objects)
AverageScoreDisplay averageScoreDisplay = new AverageScoreDisplay();
CurrentScoreDisplay currentScoreDisplay = new CurrentScoreDisplay();

//Pass the displays to cricket data
CricketData cricketData = new CricketData();

//Register display elements
cricketData.RegisterObserver(averageScoreDisplay);
cricketData.RegisterObserver(currentScoreDisplay);

//In real app you would have some logic to
//call this function when data changes
cricketData.DataChanged();

//Remove an observer
cricketData.UnRegisterObject(averageScoreDisplay);

//Now only currentScoreDisplay gets the
//notification
cricketData.DataChanged();