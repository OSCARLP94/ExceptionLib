# ExceptionLib
Simple Package for manage responses and exceptions

***** Examples use:
1. Successful (return an Successful object): 
  return ExceptionLib.Response.Successful(new { id = user.Id, services = accessesTokenUser });
  
2. WithException:
            catch(Exception ex)
            {
                return ExceptionLib.Response.WithErrorException(ex);
            }
            
    
