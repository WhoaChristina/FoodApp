import { useEffect, useState } from "react";
import GetRandom from "../../Services/GetRandomService"
import StartComponent from "../../Components/Start/StartComponent"

const StartContainer = () =>
{
    const [Random, setRandom] = useState();
    const [RandCat, setRandCat] = useState();

    const getRandom = async () =>
    {
        const res = await GetRandom();
        setRandom(res);
    }
    
    useEffect(() => {
        getRandom();
    }, [])

    if(Random !== undefined)
    {
        return(<>
            <StartComponent name = {Random.name}/>
            </>)    
    }

}
export default StartContainer;