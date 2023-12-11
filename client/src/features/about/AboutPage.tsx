import { Divider, Grid,Typography } from "@mui/material";
import { useEffect, useState } from "react";
export default function AboutPage() {



    const [isVisible, setIsVisible] = useState(false);

  useEffect(() => {
    setTimeout(() => {
      setIsVisible(true);
    }, 200);
  }, []);

  return (
    <Grid container spacing={1}>
      <Grid item xs={6}>
      <img
  src="/images/products/Progetto senza titolo (1).png"
  alt="Progetto senza titolo (1).png"
  style={{
    width: '80%',
    opacity: isVisible ? 1 : 0,
    transition: 'opacity 1s',
    boxShadow: isVisible ? '0 0 10px rgba(0, 0, 0, 0.4)' : 'none'
  }}
/>
      </Grid>
      <Grid item xs={6} textAlign={"center"}>
        <div style={{ opacity: isVisible ? 1 : 0, transition: 'opacity 3s' }}>
          <Typography 
          variant='h3' marginTop={6}  
          style={{textShadow: '2px 2px 4px rgba(0, 0, 0, 0.3)' }}>
            About us
          </Typography>
          <Divider sx={{ mb: 2, boxShadow: isVisible ? '0 0 5px rgba(0, 0, 0, 0.6)' : 'none' }}/>
          <Typography variant='h5' fontWeight={3}>
            At <span style={{fontStyle:"italic", fontFamily:"bold"}}>My-Store</span> , we are avid console video game enthusiasts, and our mission is to share our passion with you. We've embarked on a journey to curate an exceptional selection of console games, accessories, and related products to elevate your gaming experience.

            Gaming is more than a pastime; it's a way to connect, challenge, and have fun with friends and family.
            
            We're here to help you create unforgettable gaming moments by providing top-notch products and personalized service.

            We deeply care about our customers and want to ensure your shopping experience is seamless and enjoyable.

            Your trust and support mean the world to us.
          </Typography>
        </div>
      </Grid>
    </Grid>
  );
}


