﻿using OffersServiceGetRequests;

string endpoint = "";
string accessToken = "";
    int numTasks = 1;

Task[] tasks = new Task[numTasks];

for (int i = 0; i < numTasks; i++)
{
    PostRequest request = new PostRequest(endpoint, accessToken);
    tasks[i] = request.PostReq();
}
await Task.WhenAll(tasks);



