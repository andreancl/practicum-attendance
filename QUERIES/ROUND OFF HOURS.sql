UPDATE attendance SET TimeLogIn_AM = DATE_FORMAT(DATE_ADD(TimeLogIn_AM, INTERVAL 30 MINUTE),'%Y-%m-%d %H:00:00'),
TimeLogOut_AM = DATE_FORMAT(DATE_ADD(TimeLogOut_AM, INTERVAL 30 MINUTE),'%Y-%m-%d %H:00:00'),
TimeLogIn_PM = DATE_FORMAT(DATE_ADD(TimeLogIn_PM, INTERVAL 30 MINUTE),'%Y-%m-%d %H:00:00'),
TimeLogOut_PM = DATE_FORMAT(DATE_ADD(TimeLogOut_PM, INTERVAL 30 MINUTE),'%Y-%m-%d %H:00:00')