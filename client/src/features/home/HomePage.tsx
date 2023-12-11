import { Button,Grid, Typography } from "@mui/material";
import { useState, useEffect } from "react";

import { Link } from "react-router-dom";

export default function HomePage() {
  const [isVisible, setIsVisible] = useState(false);

  useEffect(() => {
    setTimeout(() => {
      setIsVisible(true);
    }, 200);
  }, []);

  return (
    <Grid container style={{ marginTop: -31, position: 'relative' }}>
      <Grid item xs={12}>
        <img
          src="/images/products/banner1.jpg"
          style={{
            display: 'block',
            margin: '0 auto',
            maxWidth: '100%',
            opacity: isVisible ? 1 : 0,
            transition: 'opacity 1s',
            boxShadow: isVisible ? '0 0 10px rgba(0, 0, 0, 0.4)' : 'none',
          }}
        />
        <Link to="/catalog">
          <Button
            variant="contained"
            size="large"
            style={{
              position: 'absolute',
              top: '50%',
              left: '50%',
              transform: 'translate(-50%, -50%)',
              border: 'none',
              cursor: 'pointer',
              backgroundColor: 'primary',
              fontSize: 23,
              transition: 'opacity 12s',
            }}
          >
            LET'S START!!
          </Button>
        </Link>
      </Grid>  
    </Grid>
  );
          }