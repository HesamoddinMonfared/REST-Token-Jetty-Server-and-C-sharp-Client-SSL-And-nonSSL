
import javax.ws.rs.*;
import javax.ws.rs.core.MediaType;


@Path("/ep")
public class MyEndpoint {

    @Path("pi")
    @Produces(MediaType.TEXT_HTML)
    @GET
    public String ping(){
        return "Hello from ping";
    }

}
