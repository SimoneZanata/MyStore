import { Button, Divider, Grid, Typography } from '@mui/material';
import { useState, useEffect } from 'react';
import LoadingComponent from '../../app/layout/LoadingComponent';

export default function ContactPage() {
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
          src="/images/products/callUs.jpg"
          alt="callUs.jpg"
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
            style={{ textShadow: '2px 2px 4px rgba(0, 0, 0, 0.3)' }}>
            Contact Us
          </Typography>
          <Divider sx={{ mb: 2, boxShadow: isVisible ? '0 0 5px rgba(0, 0, 0, 0.6)' : 'none' }} />

          <Typography variant='h5' fontWeight={3}>
            Got questions, suggestions, or just want to chat about your favorite games? We're here for you!

            Reach out to us via email at <span style={{ fontStyle: "italic" }}>support@my-store.com</span> or give us a call at <span style={{ fontStyle: "italic" }}>(555) 123-4567</span>.

            Our dedicated team is available from Monday to Friday, 9 AM to 6 PM, to assist you.

            Connect with us on social media for the latest updates and gaming community discussions:
            <ul>
              <li>Twitter: <a href="">@my_store</a></li>
              <li>Instagram: <a href="">@my_store</a></li>
              <li>Facebook: <a href="">/my_store</a></li>
            </ul>

            Your feedback is invaluable in helping us enhance your gaming experience. Let's continue this gaming journey together!
          </Typography>
        </div>
      </Grid>
    </Grid>
  );
}
