// See https://aka.ms/new-console-template for more information


WetherSubject wetherSubject = new WetherSubject();
DisplayObserver displayObserver = new DisplayObserver(wetherSubject);
ConsoleObserver consoleObserver = new ConsoleObserver(wetherSubject);

wetherSubject.temperatureChanged();
wetherSubject.temperatureChanged();
wetherSubject.temperatureChanged();
